namespace Projeto02
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
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.porcento = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.somar = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.indicarOperacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.resultLabel.Location = new System.Drawing.Point(94, 12);
            this.resultLabel.Multiline = true;
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(236, 47);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultLabel.TextChanged += new System.EventHandler(this.resultLabel_TextChanged);
            // 
            // porcento
            // 
            this.porcento.BackColor = System.Drawing.Color.DarkSlateGray;
            this.porcento.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.porcento.Location = new System.Drawing.Point(13, 65);
            this.porcento.Name = "porcento";
            this.porcento.Size = new System.Drawing.Size(75, 46);
            this.porcento.TabIndex = 1;
            this.porcento.Text = "%";
            this.porcento.UseVisualStyleBackColor = false;
            this.porcento.Click += new System.EventHandler(this.porcento_Click);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.apagar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.apagar.Location = new System.Drawing.Point(94, 65);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 46);
            this.apagar.TabIndex = 2;
            this.apagar.Text = "CE";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sair.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sair.Location = new System.Drawing.Point(256, 65);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 46);
            this.sair.TabIndex = 4;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // sete
            // 
            this.sete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sete.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sete.Location = new System.Drawing.Point(13, 117);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(75, 46);
            this.sete.TabIndex = 9;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = false;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // oito
            // 
            this.oito.BackColor = System.Drawing.Color.DarkSlateGray;
            this.oito.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.oito.Location = new System.Drawing.Point(94, 117);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(75, 46);
            this.oito.TabIndex = 10;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = false;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // nove
            // 
            this.nove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nove.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nove.Location = new System.Drawing.Point(175, 117);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(75, 46);
            this.nove.TabIndex = 11;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = false;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.multiplicar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multiplicar.Location = new System.Drawing.Point(256, 117);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 46);
            this.multiplicar.TabIndex = 12;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // quatro
            // 
            this.quatro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.quatro.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.quatro.Location = new System.Drawing.Point(13, 169);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(75, 46);
            this.quatro.TabIndex = 13;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = false;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cinco.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cinco.Location = new System.Drawing.Point(94, 169);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(75, 46);
            this.cinco.TabIndex = 14;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.seis.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seis.Location = new System.Drawing.Point(175, 169);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(75, 46);
            this.seis.TabIndex = 15;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // somar
            // 
            this.somar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.somar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.somar.Location = new System.Drawing.Point(256, 169);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(75, 46);
            this.somar.TabIndex = 16;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = false;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // um
            // 
            this.um.BackColor = System.Drawing.Color.DarkSlateGray;
            this.um.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.um.Location = new System.Drawing.Point(12, 221);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(75, 46);
            this.um.TabIndex = 17;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // dois
            // 
            this.dois.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dois.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dois.Location = new System.Drawing.Point(94, 221);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(75, 46);
            this.dois.TabIndex = 18;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = false;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tres.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tres.Location = new System.Drawing.Point(175, 221);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(75, 46);
            this.tres.TabIndex = 19;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // subtrair
            // 
            this.subtrair.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subtrair.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subtrair.Location = new System.Drawing.Point(256, 221);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(75, 46);
            this.subtrair.TabIndex = 20;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = false;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dividir.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dividir.Location = new System.Drawing.Point(13, 273);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 46);
            this.dividir.TabIndex = 21;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.DarkSlateGray;
            this.zero.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zero.Location = new System.Drawing.Point(94, 273);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 46);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.DarkSlateGray;
            this.igual.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.igual.Location = new System.Drawing.Point(175, 273);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(156, 46);
            this.igual.TabIndex = 24;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // ponto
            // 
            this.ponto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ponto.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ponto.Location = new System.Drawing.Point(175, 65);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(75, 46);
            this.ponto.TabIndex = 25;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = false;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // indicarOperacao
            // 
            this.indicarOperacao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.indicarOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicarOperacao.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.indicarOperacao.Location = new System.Drawing.Point(13, 12);
            this.indicarOperacao.Multiline = true;
            this.indicarOperacao.Name = "indicarOperacao";
            this.indicarOperacao.Size = new System.Drawing.Size(75, 47);
            this.indicarOperacao.TabIndex = 26;
            this.indicarOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indicarOperacao.TextChanged += new System.EventHandler(this.indicadarOperacao_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(349, 338);
            this.Controls.Add(this.indicarOperacao);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.porcento);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultLabel;
        private System.Windows.Forms.Button porcento;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.TextBox indicarOperacao;
    }
}

