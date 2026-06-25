namespace PI0924_Aulas
{
    partial class frm_inputbox
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
            this.btn_inserirnome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nomeinserido = new System.Windows.Forms.Label();
            this.btn_menuPrincipal = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Box";
            // 
            // btn_inserirnome
            // 
            this.btn_inserirnome.Location = new System.Drawing.Point(34, 88);
            this.btn_inserirnome.Name = "btn_inserirnome";
            this.btn_inserirnome.Size = new System.Drawing.Size(94, 40);
            this.btn_inserirnome.TabIndex = 3;
            this.btn_inserirnome.Text = "Inserir Nome";
            this.btn_inserirnome.UseVisualStyleBackColor = true;
            this.btn_inserirnome.Click += new System.EventHandler(this.btn_inserirnome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "O nome inserido foi:";
            // 
            // lbl_nomeinserido
            // 
            this.lbl_nomeinserido.AutoSize = true;
            this.lbl_nomeinserido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeinserido.Location = new System.Drawing.Point(215, 155);
            this.lbl_nomeinserido.Name = "lbl_nomeinserido";
            this.lbl_nomeinserido.Size = new System.Drawing.Size(15, 24);
            this.lbl_nomeinserido.TabIndex = 5;
            this.lbl_nomeinserido.Text = " ";
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_menuPrincipal.IconColor = System.Drawing.Color.Black;
            this.btn_menuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menuPrincipal.IconSize = 32;
            this.btn_menuPrincipal.Location = new System.Drawing.Point(399, 398);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(97, 40);
            this.btn_menuPrincipal.TabIndex = 6;
            this.btn_menuPrincipal.Text = "Voltar";
            this.btn_menuPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // frm_inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Controls.Add(this.lbl_nomeinserido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inserirnome);
            this.Controls.Add(this.label1);
            this.Name = "frm_inputbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_inputbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inserirnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nomeinserido;
        private FontAwesome.Sharp.IconButton btn_menuPrincipal;
    }
}