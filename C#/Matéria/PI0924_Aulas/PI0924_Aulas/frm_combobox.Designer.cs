namespace PI0924_Aulas
{
    partial class frm_combobox
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_marcas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Combo Box | List Box";
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_menuPrincipal.IconColor = System.Drawing.Color.Black;
            this.btn_menuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menuPrincipal.IconSize = 32;
            this.btn_menuPrincipal.Location = new System.Drawing.Point(411, 398);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(97, 40);
            this.btn_menuPrincipal.TabIndex = 7;
            this.btn_menuPrincipal.Text = "Voltar";
            this.btn_menuPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marca automóvel";
            // 
            // cb_marcas
            // 
            this.cb_marcas.FormattingEnabled = true;
            this.cb_marcas.Items.AddRange(new object[] {
            "Toyota",
            "Nissan",
            "Mazda",
            "Subaru",
            "Mitsubishi",
            "Lexus",
            "Datsun",
            "Honda",
            "Ford",
            "Chevrolet",
            "Dodge",
            "Chrysler",
            "Lotus",
            "Maserati",
            "Ferrari",
            "Lamborghini",
            "BMW",
            "Mercedes-Benz",
            "Audi",
            "Porsche"});
            this.cb_marcas.Location = new System.Drawing.Point(26, 140);
            this.cb_marcas.Name = "cb_marcas";
            this.cb_marcas.Size = new System.Drawing.Size(242, 21);
            this.cb_marcas.TabIndex = 9;
            this.cb_marcas.SelectedIndexChanged += new System.EventHandler(this.cb_marcas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modelo";
            // 
            // cb_modelo
            // 
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(26, 219);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(242, 21);
            this.cb_modelo.TabIndex = 11;
            // 
            // frm_combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_marcas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "frm_combobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_menuPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_marcas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_modelo;
    }
}