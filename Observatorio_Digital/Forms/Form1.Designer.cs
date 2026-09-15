namespace api_astronomia_teste01
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtitulo = new System.Windows.Forms.Label();
			this.lblExemplo = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.picImagem = new System.Windows.Forms.PictureBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblDescricao = new System.Windows.Forms.Label();
			this.rtbDescricao = new System.Windows.Forms.RichTextBox();
			this.lblImagem = new System.Windows.Forms.Label();
			this.lblInstrucao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(491, 26);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(453, 53);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Observatório Estelar";
			// 
			// lblSubtitulo
			// 
			this.lblSubtitulo.AutoSize = true;
			this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
			this.lblSubtitulo.Location = new System.Drawing.Point(92, 90);
			this.lblSubtitulo.Name = "lblSubtitulo";
			this.lblSubtitulo.Size = new System.Drawing.Size(1272, 32);
			this.lblSubtitulo.TabIndex = 1;
			this.lblSubtitulo.Text = "Bem vindo(a) ao observatório digital! Escolha uma data e veja qual a imagem astro" +
    "nômica desse dia!!";
			// 
			// lblExemplo
			// 
			this.lblExemplo.AutoSize = true;
			this.lblExemplo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExemplo.ForeColor = System.Drawing.Color.White;
			this.lblExemplo.Location = new System.Drawing.Point(94, 122);
			this.lblExemplo.Name = "lblExemplo";
			this.lblExemplo.Size = new System.Drawing.Size(540, 23);
			this.lblExemplo.TabIndex = 2;
			this.lblExemplo.Text = "Exemplos: Seu aniversário, dia de hoje, uma data especial...";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblData.ForeColor = System.Drawing.Color.White;
			this.lblData.Location = new System.Drawing.Point(92, 212);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(86, 33);
			this.lblData.TabIndex = 3;
			this.lblData.Text = "Data:";
			// 
			// dtpData
			// 
			this.dtpData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpData.Location = new System.Drawing.Point(184, 206);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(200, 39);
			this.dtpData.TabIndex = 4;
			this.dtpData.Value = new System.DateTime(2026, 9, 12, 0, 0, 0, 0);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnPesquisar.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.ForeColor = System.Drawing.Color.White;
			this.btnPesquisar.Location = new System.Drawing.Point(98, 269);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(187, 99);
			this.btnPesquisar.TabIndex = 5;
			this.btnPesquisar.Text = "Pesquisar Data";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// picImagem
			// 
			this.picImagem.Location = new System.Drawing.Point(760, 206);
			this.picImagem.Name = "picImagem";
			this.picImagem.Size = new System.Drawing.Size(604, 604);
			this.picImagem.TabIndex = 6;
			this.picImagem.TabStop = false;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.White;
			this.lblStatus.Location = new System.Drawing.Point(94, 393);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(96, 23);
			this.lblStatus.TabIndex = 7;
			this.lblStatus.Text = "Status. . .";
			// 
			// lblDescricao
			// 
			this.lblDescricao.AutoSize = true;
			this.lblDescricao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescricao.ForeColor = System.Drawing.Color.White;
			this.lblDescricao.Location = new System.Drawing.Point(93, 460);
			this.lblDescricao.Name = "lblDescricao";
			this.lblDescricao.Size = new System.Drawing.Size(253, 27);
			this.lblDescricao.TabIndex = 8;
			this.lblDescricao.Text = "Descrição da Imagem:";
			// 
			// rtbDescricao
			// 
			this.rtbDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbDescricao.Location = new System.Drawing.Point(98, 507);
			this.rtbDescricao.Name = "rtbDescricao";
			this.rtbDescricao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbDescricao.Size = new System.Drawing.Size(536, 303);
			this.rtbDescricao.TabIndex = 9;
			this.rtbDescricao.Text = "";
			// 
			// lblImagem
			// 
			this.lblImagem.AutoSize = true;
			this.lblImagem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImagem.ForeColor = System.Drawing.Color.White;
			this.lblImagem.Location = new System.Drawing.Point(652, 206);
			this.lblImagem.Name = "lblImagem";
			this.lblImagem.Size = new System.Drawing.Size(102, 27);
			this.lblImagem.TabIndex = 10;
			this.lblImagem.Text = "Imagem:";
			// 
			// lblInstrucao
			// 
			this.lblInstrucao.AutoSize = true;
			this.lblInstrucao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstrucao.ForeColor = System.Drawing.Color.White;
			this.lblInstrucao.Location = new System.Drawing.Point(94, 145);
			this.lblInstrucao.Name = "lblInstrucao";
			this.lblInstrucao.Size = new System.Drawing.Size(556, 23);
			this.lblInstrucao.TabIndex = 11;
			this.lblInstrucao.Text = "Depois de selecionar a data, clique no botão \"Pesquisar Data\"";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1445, 848);
			this.Controls.Add(this.lblInstrucao);
			this.Controls.Add(this.lblImagem);
			this.Controls.Add(this.rtbDescricao);
			this.Controls.Add(this.lblDescricao);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.picImagem);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.dtpData);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.lblExemplo);
			this.Controls.Add(this.lblSubtitulo);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.Text = "Observatório Digital";
			((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSubtitulo;
		private System.Windows.Forms.Label lblExemplo;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.PictureBox picImagem;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblDescricao;
		private System.Windows.Forms.RichTextBox rtbDescricao;
		private System.Windows.Forms.Label lblImagem;
		private System.Windows.Forms.Label lblInstrucao;
	}
}

