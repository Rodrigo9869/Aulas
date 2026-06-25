namespace PI0924_Aulas
{
    partial class frm_Cx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_apelido = new System.Windows.Forms.TextBox();
            this.txt_nome_completo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_nome_completo = new System.Windows.Forms.Button();
            this.btn_limpar_nome = new System.Windows.Forms.Button();
            this.btn_limparTudo = new System.Windows.Forms.Button();
            this.btn_Limpar_Apelido = new System.Windows.Forms.Button();
            this.btn_Limpar_Completo = new System.Windows.Forms.Button();
            this.lbl_corFundo = new System.Windows.Forms.Label();
            this.btn_corFundo = new System.Windows.Forms.Button();
            this.btn_resetColor = new System.Windows.Forms.Button();
            this.lbl_aletaorio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa de Texto";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(908, 415);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(136, 92);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(220, 20);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // txt_apelido
            // 
            this.txt_apelido.Location = new System.Drawing.Point(136, 133);
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.Size = new System.Drawing.Size(220, 20);
            this.txt_apelido.TabIndex = 3;
            this.txt_apelido.Enter += new System.EventHandler(this.txt_apelido_Enter);
            // 
            // txt_nome_completo
            // 
            this.txt_nome_completo.Location = new System.Drawing.Point(136, 178);
            this.txt_nome_completo.Name = "txt_nome_completo";
            this.txt_nome_completo.Size = new System.Drawing.Size(220, 20);
            this.txt_nome_completo.TabIndex = 4;
            this.txt_nome_completo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_nome_completo_MouseClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apelido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome Completo";
            // 
            // btn_nome_completo
            // 
            this.btn_nome_completo.Location = new System.Drawing.Point(136, 214);
            this.btn_nome_completo.Name = "btn_nome_completo";
            this.btn_nome_completo.Size = new System.Drawing.Size(220, 38);
            this.btn_nome_completo.TabIndex = 8;
            this.btn_nome_completo.Text = "Ver nome completo";
            this.btn_nome_completo.UseVisualStyleBackColor = true;
            this.btn_nome_completo.Click += new System.EventHandler(this.btn_nome_completo_Click);
            // 
            // btn_limpar_nome
            // 
            this.btn_limpar_nome.Location = new System.Drawing.Point(366, 92);
            this.btn_limpar_nome.Name = "btn_limpar_nome";
            this.btn_limpar_nome.Size = new System.Drawing.Size(106, 22);
            this.btn_limpar_nome.TabIndex = 9;
            this.btn_limpar_nome.Text = "Limpar Nome";
            this.btn_limpar_nome.UseVisualStyleBackColor = true;
            this.btn_limpar_nome.Click += new System.EventHandler(this.btn_limpar_nome_Click);
            // 
            // btn_limparTudo
            // 
            this.btn_limparTudo.Location = new System.Drawing.Point(138, 271);
            this.btn_limparTudo.Name = "btn_limparTudo";
            this.btn_limparTudo.Size = new System.Drawing.Size(217, 37);
            this.btn_limparTudo.TabIndex = 10;
            this.btn_limparTudo.Text = "Limpar tudo";
            this.btn_limparTudo.UseVisualStyleBackColor = true;
            this.btn_limparTudo.Click += new System.EventHandler(this.btn_limparTudo_Click);
            // 
            // btn_Limpar_Apelido
            // 
            this.btn_Limpar_Apelido.Location = new System.Drawing.Point(366, 134);
            this.btn_Limpar_Apelido.Name = "btn_Limpar_Apelido";
            this.btn_Limpar_Apelido.Size = new System.Drawing.Size(106, 22);
            this.btn_Limpar_Apelido.TabIndex = 9;
            this.btn_Limpar_Apelido.Text = "Limpar Apelido";
            this.btn_Limpar_Apelido.UseVisualStyleBackColor = true;
            this.btn_Limpar_Apelido.Click += new System.EventHandler(this.btn_Limpar_Apelido_Click);
            // 
            // btn_Limpar_Completo
            // 
            this.btn_Limpar_Completo.Location = new System.Drawing.Point(366, 178);
            this.btn_Limpar_Completo.Name = "btn_Limpar_Completo";
            this.btn_Limpar_Completo.Size = new System.Drawing.Size(106, 22);
            this.btn_Limpar_Completo.TabIndex = 9;
            this.btn_Limpar_Completo.Text = "Limpar Completo";
            this.btn_Limpar_Completo.UseVisualStyleBackColor = true;
            this.btn_Limpar_Completo.Click += new System.EventHandler(this.btn_Limpar_Completo_Click);
            // 
            // lbl_corFundo
            // 
            this.lbl_corFundo.AutoSize = true;
            this.lbl_corFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_corFundo.Location = new System.Drawing.Point(551, 92);
            this.lbl_corFundo.Name = "lbl_corFundo";
            this.lbl_corFundo.Size = new System.Drawing.Size(144, 26);
            this.lbl_corFundo.TabIndex = 11;
            this.lbl_corFundo.Text = "Cor de Fundo";
            // 
            // btn_corFundo
            // 
            this.btn_corFundo.Location = new System.Drawing.Point(556, 130);
            this.btn_corFundo.Name = "btn_corFundo";
            this.btn_corFundo.Size = new System.Drawing.Size(139, 23);
            this.btn_corFundo.TabIndex = 12;
            this.btn_corFundo.Text = "Cor de Fundo";
            this.btn_corFundo.UseVisualStyleBackColor = true;
            this.btn_corFundo.Click += new System.EventHandler(this.btn_corFundo_Click);
            // 
            // btn_resetColor
            // 
            this.btn_resetColor.Location = new System.Drawing.Point(556, 160);
            this.btn_resetColor.Name = "btn_resetColor";
            this.btn_resetColor.Size = new System.Drawing.Size(139, 23);
            this.btn_resetColor.TabIndex = 13;
            this.btn_resetColor.Text = "Reset Color";
            this.btn_resetColor.UseVisualStyleBackColor = true;
            this.btn_resetColor.Click += new System.EventHandler(this.btn_resetColor_Click);
            // 
            // lbl_aletaorio
            // 
            this.lbl_aletaorio.AutoSize = true;
            this.lbl_aletaorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aletaorio.Location = new System.Drawing.Point(792, 136);
            this.lbl_aletaorio.Name = "lbl_aletaorio";
            this.lbl_aletaorio.Size = new System.Drawing.Size(34, 29);
            this.lbl_aletaorio.TabIndex = 14;
            this.lbl_aletaorio.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(739, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nº Aleatório";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(138, 358);
            this.maskedTextBox1.Mask = "00 000 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(217, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telemóvel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "Escrever\r\nvárias linhas\r\nnuma label.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // frm_Cx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_aletaorio);
            this.Controls.Add(this.btn_resetColor);
            this.Controls.Add(this.btn_corFundo);
            this.Controls.Add(this.lbl_corFundo);
            this.Controls.Add(this.btn_limparTudo);
            this.Controls.Add(this.btn_Limpar_Completo);
            this.Controls.Add(this.btn_Limpar_Apelido);
            this.Controls.Add(this.btn_limpar_nome);
            this.Controls.Add(this.btn_nome_completo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_completo);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label1);
            this.Name = "frm_Cx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cx";
            this.Load += new System.EventHandler(this.frm_Cx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_apelido;
        private System.Windows.Forms.TextBox txt_nome_completo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_nome_completo;
        private System.Windows.Forms.Button btn_limpar_nome;
        private System.Windows.Forms.Button btn_limparTudo;
        private System.Windows.Forms.Button btn_Limpar_Apelido;
        private System.Windows.Forms.Button btn_Limpar_Completo;
        private System.Windows.Forms.Label lbl_corFundo;
        private System.Windows.Forms.Button btn_corFundo;
        private System.Windows.Forms.Button btn_resetColor;
        private System.Windows.Forms.Label lbl_aletaorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}