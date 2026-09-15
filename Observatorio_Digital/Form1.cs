using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Bem vindo usuário!!
 * Este programa é um exemplo de como consumir a API da NASA para obter a imagem do dia (APOD - Astronomy Picture of the Day).
 * Ele também utiliza a API DeepL para traduzir o título e a descrição da imagem para o português.
 * 
 * Para usar a tradução, você precisa colocar sua chave do DeepL na variável 'chaveDeepL' abaixo. (Linha 35)
 * Se você não quiser usar a tradução, deixe a variável vazia. Isso fará com que o programa exiba o título e a descrição da imagem em inglês.
 * Para saber como obter uma chave do DeepL, acesse: https://www.deepl.com/en/developers OU leia o README do projeto.
 * Não se preocupe, criar uma chave é gratuito, você só precisa criar uma conta no DeepL.
 * 
 * Você verá muitos comentários ao longo do código, eu uso eles para não me perder pois ainda estou aprendendo a programar,
   ignore esses comentários se quiser, mas caso você seja um programador iniciante eles podem te ajudar a entender o que cada parte do código faz.
 */

namespace api_astronomia_teste01
{
	public partial class Form1 : Form
	{

		//Para ativar a tradução, coloque sua chave do DeepL entre as aspas.
		//Deixe vazio para usar o programa em inglês.
		private readonly string chaveDeepL = "bafec6fc-1c2e-40d0-b41b-6b3b0a8d089e:fx";


		private readonly HttpClient client = new HttpClient
		{
			BaseAddress = new Uri("https://api.nasa.gov/") //Configura a URL base da API
		};
		private readonly HttpClient tradutorClient = new HttpClient
		{
			BaseAddress = new Uri("https://api-free.deepl.com/") //API para tradução de textos
		};

		public Form1()
		{
			InitializeComponent();

			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); //Falando que a API aceita receber e enviar dados no formato JSON

			picImagem.SizeMode = PictureBoxSizeMode.Zoom; //Faz com que a imagem fique do tamanho do PictureBox, sem distorcer a imagem

			lblStatus.Text = "Status: Aguardando uma data...";
			picImagem.LoadCompleted += (sender, e) =>
			{
				if (e.Cancelled)
				{
					lblStatus.Text = "Status: Carregamento cancelado.";
				}
				else if (e.Error != null)
				{
					lblStatus.Text = "Status: Não foi possível carregar a imagem.";
				}
				else
				{
					lblStatus.Text = "Status: Imagem carregada!";
				}
			};
		}

		private async void btnPesquisar_Click(object sender, EventArgs e)
		{
			string data = dtpData.Value.ToString("yyyy-MM-dd");

			string url = $"planetary/apod?api_key=TOp3aiIHkagL37tBtwtLi26yrStoPCxUNKmTlcYF&date={data}";

			Apod resultado = await client.GetFromJsonAsync<Apod>(url);
			if (resultado == null)
			{
				MessageBox.Show("Não foi possível obter os dados.");
				return;
			}

			//Antes era isso:
			//rtbDescricao.Text = $"Título: {resultado.Title}\r\n\r\n" + $"Descrição: {resultado.Explanation}";
			//Agora virou isso para traduzir os textos:

			string titulo = resultado.Title; //Mantém os textos originais caso a tradução falhe.
			string descricao = resultado.Explanation;
			string aviso = "";

			btnPesquisar.Enabled = false;
			lblStatus.Text = "Status: Traduzindo para português...";

			try
			{
				var traducao = await TraduzirAsync(titulo, descricao);

				titulo = traducao.Traducoes[0].Texto;
				descricao = traducao.Traducoes[1].Texto;
			}
			catch (Exception)
			{
				aviso = "Tradução indisponível no momento. " + "Exibindo o texto original.\r\n\r\n";
			}
			finally
			{
				btnPesquisar.Enabled = true; //Reativa o botão mesmo se ocorrer um erro.
			}

			rtbDescricao.Text = aviso + $"Título: {titulo}\r\n\r\n" + $"Descrição: {descricao}";

			picImagem.Image = null; //Remove a imagem da pesquisa anterior.

			if (resultado.MediaType == "image") //Verifica se o tipo de mídia é uma imagem
			{
				if (!string.IsNullOrWhiteSpace(resultado.Url))
				{
					lblStatus.Text = "Status: Carregando imagem...";
					picImagem.LoadAsync(resultado.Url);
				}
				else
				{
					lblStatus.Text = "Status: Imagem sem endereço disponível.";
				}
			}
			else
			{
				lblStatus.Text = "Status: Esta data possui um vídeo ou outra mídia.";
			}
		}

		//Método para traduzir o título e a descrição usando a API DeepL:
		private async Task<RespostaTraducao> TraduzirAsync(string titulo, string descricao)
		{
			string chave = chaveDeepL;

			if (string.IsNullOrWhiteSpace(chave))
			{
				throw new InvalidOperationException(
					"Tradução não configurada. Exibindo o conteúdo em inglês.");
			}

			using (var requisicao = new HttpRequestMessage(
				HttpMethod.Post, "v2/translate"))
			{
				requisicao.Headers.Authorization =
					new AuthenticationHeaderValue("DeepL-Auth-Key", chave);

				requisicao.Content = JsonContent.Create(new
				{
					text = new[] { titulo, descricao },
					source_lang = "EN",
					target_lang = "PT-BR"
				});

				using (var resposta = await tradutorClient.SendAsync(requisicao))
				{
					resposta.EnsureSuccessStatusCode();

					var resultado =
						await resposta.Content.ReadFromJsonAsync<RespostaTraducao>();

					if (resultado?.Traducoes == null ||
						resultado.Traducoes.Count != 2 ||
						string.IsNullOrWhiteSpace(resultado.Traducoes[0].Texto) ||
						string.IsNullOrWhiteSpace(resultado.Traducoes[1].Texto))
					{
						throw new InvalidOperationException(
							"A API não retornou os dois textos traduzidos.");
					}

					return resultado;
				}
			}
		}
	}

	public class Apod //Essa classe representa os dados que queremos receber da NASA
	{
		public string Title { get; set; }
		public string Explanation { get; set; }
		public string Url { get; set; }
		public string Date { get; set; }

		[JsonPropertyName("media_type")] //Isso é pra caso não venha uma imagem e sim um vídeo, a gente consiga identificar o tipo de mídia que está sendo retornada
		public string MediaType { get; set; }
	}

	//Classes para tradução de textos:
	public class RespostaTraducao
	{
		[JsonPropertyName("translations")]
		public List<TextoTraduzido> Traducoes { get; set; }
	}

	public class TextoTraduzido
	{
		[JsonPropertyName("text")]
		public string Texto { get; set; }
	}
}
