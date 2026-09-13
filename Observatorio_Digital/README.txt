Observatório Digital

Aplicação desenvolvida em C# com Windows Forms que permite explorar o conteúdo astronômico de uma data escolhida pelo usuário, utilizando a API APOD (Astronomy Picture of the Day), da NASA.
Esse é um projeto pequeno que criei para estudar o consumo de APIs. É minha segunda vez fazendo algo com APIs, então ainda estou em fase experimental.

Funcionalidades:
Consulta do conteúdo astronômico de uma data selecionada;
Exibição da imagem, título e da descrição fornecidas pela NASA;
Tradução opcional do título e da descrição para português brasileiro com a API do DeepL;
Exibição do texto original em inglês quando a tradução não estiver configurada ou falhar;
Identificação de datas com vídeos ou outras mídias, com um aviso na interface;
Vídeos ou outros tipos de mídia não são reproduzidos dentro do programa;

Tecnologias utilizadas:
C#
Windows Forms
HttpClient para comunicação com as APIs
System.Net.Http.Json e System.Text.Json.Serialization para trabalhar com JSON
API APOD da NASA
API do DeepL

————————————————————————————————————————————————————————————————————————————————————————————————————————————————

Como executar:
Baixe esse repositório ou faça um clone;
Abra o arquivo de solução (.slnx) no Visual Studio;
Tenha instalado a versão do .NET exigida pelo projeto;
Execute o projeto pelo Visual Studio.
Se desejar traduzir os textos, configure sua chave do DeepL seguindo as instruções abaixo:

//É necessário ter conexão com a internet para consultar as APIs e carregar as imagens.

Como configurar a tradução com o DeepL:

Obtenha uma chave de API
	Acesse o DeepL para desenvolvedores (https://www.deepl.com/en/developers) e clique em "Get a free API key".
	Crie uma conta e, na sua conta, acesse "API Keys & Limits" e copie sua chave.
	O plano gratuito deve oferecer 1 milhão de caracteres, selecione esse plano ou confira os outros planos.

2. Coloque sua chave no código
	Abra o arquivo Form1.cs e localize a variável no início da classe Form1:
		private readonly string chaveDeepL = "";
	Cole sua chave entre as aspas:
		private readonly string chaveDeepL = "SUA_CHAVE_AQUI";
	(SUA_CHAVE_AQUI é apenas um exemplo. Substitua esse texto pela chave obtida na sua conta)
	Salve o programa e execute o programa novamente.

3. Teste a tradução
	Escolha uma data e clique em "Pesquisar Data".
	Com uma chave válida e cota disponível, o programa tentará traduzir o título e a descrição para português brasileiro.
	Se a tradução falhar, o conteúdo original em inglês será mantido.

Para usar sem tradução deixe a variável com as aspas vazias:
	private readonly string chaveDeepL = "";

A chave identifica sua conta e permite consumir sua cota de tradução. Utilize sua própria chave. Não compartilhe a chave em posts, capturas de tela ou arquivos públicos. Essa configuração no código é destinada a testes locais de quem baixa o projeto.

————————————————————————————————————————————————————————————————————————————————————————————————————————————————

Acesso à API da NASA

O código utiliza a chave de demonstração DEMO_KEY para consultar a NASA:
	string url = $"planetary/apod?api_key=DEMO_KEY&date={data}";

Essa chave possui limites de uso. Para utilizar uma chave própria, acesse o portal de APIs da NASA e substitua DEMO_KEY no código.
Não publique sua chave pessoal caso faça essa alteração.

Limitações atuais

O programa depende da conexão com a internet e da disponibilidade dos serviços externos.
As consultas e traduções estão sujeitas aos limites das respectivas APIs.
A tradução é automática e pode apresentar imprecisões, inclusive em termos científicos.
Datas com vídeos ou outras mídias não exibem esse conteúdo no PictureBox.
As traduções não são salvas: pesquisar novamente uma data pode consumir novamente a cota do DeepL.

————————————————————————————————————————————————————————————————————————————————————————————————————————————————

Créditos

O conteúdo astronômico é fornecido pela NASA por meio da API APOD. As imagens podem ter direitos autorais de seus respectivos autores; consulte os créditos e as condições de uso do conteúdo original.

A tradução é realizada pela API do DeepL.

Este é um projeto de estudo independente, sem vínculo oficial com a NASA ou com o DeepL.

Obrigada por ler (≧◇≦)
