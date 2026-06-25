namespace PI0924_Aulas
{
    partial class frm_messageBox
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
            this.btn_menuPrincipal = new FontAwesome.Sharp.IconButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_retorno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caixa de Mensagem";
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_menuPrincipal.IconColor = System.Drawing.Color.Black;
            this.btn_menuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menuPrincipal.IconSize = 32;
            this.btn_menuPrincipal.Location = new System.Drawing.Point(691, 398);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(97, 40);
            this.btn_menuPrincipal.TabIndex = 2;
            this.btn_menuPrincipal.Text = "Voltar";
            this.btn_menuPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(50, 111);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(147, 47);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_retorno
            // 
            this.btn_retorno.Location = new System.Drawing.Point(50, 206);
            this.btn_retorno.Name = "btn_retorno";
            this.btn_retorno.Size = new System.Drawing.Size(147, 48);
            this.btn_retorno.TabIndex = 4;
            this.btn_retorno.Text = "Retorno";
            this.btn_retorno.UseVisualStyleBackColor = true;
            this.btn_retorno.Click += new System.EventHandler(this.btn_retorno_Click);
            // 
            // frm_messageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retorno);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "frm_messageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_messageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_menuPrincipal;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_retorno;
    }
}