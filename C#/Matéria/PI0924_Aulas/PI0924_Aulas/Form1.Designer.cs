namespace PI0924_Aulas
{
    partial class Form1
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
            this.btn_caixaTexto = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btn_messageBox = new FontAwesome.Sharp.IconButton();
            this.btn_inputbox = new FontAwesome.Sharp.IconButton();
            this.btn_combobox = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btn_caixaTexto
            // 
            this.btn_caixaTexto.Location = new System.Drawing.Point(44, 98);
            this.btn_caixaTexto.Name = "btn_caixaTexto";
            this.btn_caixaTexto.Size = new System.Drawing.Size(130, 38);
            this.btn_caixaTexto.TabIndex = 1;
            this.btn_caixaTexto.Text = "Caixas de Texto";
            this.btn_caixaTexto.UseVisualStyleBackColor = true;
            this.btn_caixaTexto.Click += new System.EventHandler(this.btn_caixaTexto_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(396, 386);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(130, 52);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Icon";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(260, 386);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(130, 52);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Meu Facebook";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.Location = new System.Drawing.Point(532, 386);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(54, 52);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btn_messageBox
            // 
            this.btn_messageBox.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btn_messageBox.IconColor = System.Drawing.Color.Black;
            this.btn_messageBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_messageBox.IconSize = 36;
            this.btn_messageBox.Location = new System.Drawing.Point(44, 153);
            this.btn_messageBox.Name = "btn_messageBox";
            this.btn_messageBox.Size = new System.Drawing.Size(130, 40);
            this.btn_messageBox.TabIndex = 5;
            this.btn_messageBox.Text = "MessageBox";
            this.btn_messageBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_messageBox.UseVisualStyleBackColor = true;
            this.btn_messageBox.Click += new System.EventHandler(this.btn_messageBox_Click);
            // 
            // btn_inputbox
            // 
            this.btn_inputbox.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btn_inputbox.IconColor = System.Drawing.Color.Black;
            this.btn_inputbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_inputbox.IconSize = 38;
            this.btn_inputbox.Location = new System.Drawing.Point(47, 211);
            this.btn_inputbox.Name = "btn_inputbox";
            this.btn_inputbox.Size = new System.Drawing.Size(127, 40);
            this.btn_inputbox.TabIndex = 7;
            this.btn_inputbox.Text = "Input Box";
            this.btn_inputbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inputbox.UseVisualStyleBackColor = true;
            this.btn_inputbox.Click += new System.EventHandler(this.btn_inputbox_Click);
            // 
            // btn_combobox
            // 
            this.btn_combobox.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            this.btn_combobox.IconColor = System.Drawing.Color.Black;
            this.btn_combobox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_combobox.IconSize = 26;
            this.btn_combobox.Location = new System.Drawing.Point(47, 268);
            this.btn_combobox.Name = "btn_combobox";
            this.btn_combobox.Size = new System.Drawing.Size(127, 40);
            this.btn_combobox.TabIndex = 8;
            this.btn_combobox.Text = "combo box";
            this.btn_combobox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_combobox.UseVisualStyleBackColor = true;
            this.btn_combobox.Click += new System.EventHandler(this.btn_combobox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_combobox);
            this.Controls.Add(this.btn_inputbox);
            this.Controls.Add(this.btn_messageBox);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_caixaTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_caixaTexto;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btn_messageBox;
        private FontAwesome.Sharp.IconButton btn_inputbox;
        private FontAwesome.Sharp.IconButton btn_combobox;
    }
}

