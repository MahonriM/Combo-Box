namespace Calculadora
{
    partial class Combobox
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
            this.CMB = new System.Windows.Forms.ComboBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.btnverelemento = new System.Windows.Forms.Button();
            this.btnindice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMB
            // 
            this.CMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB.FormattingEnabled = true;
            this.CMB.IntegralHeight = false;
            this.CMB.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Amarillo",
            "Azul",
            "Blanco"});
            this.CMB.Location = new System.Drawing.Point(28, 29);
            this.CMB.Name = "CMB";
            this.CMB.Size = new System.Drawing.Size(121, 21);
            this.CMB.TabIndex = 0;
            this.CMB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(170, 86);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(100, 20);
            this.txtadd.TabIndex = 8;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(170, 124);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 7;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(170, 56);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnvaciar
            // 
            this.btnvaciar.Location = new System.Drawing.Point(170, 27);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(75, 23);
            this.btnvaciar.TabIndex = 5;
            this.btnvaciar.Text = "Vaciar lista";
            this.btnvaciar.UseVisualStyleBackColor = true;
            this.btnvaciar.Click += new System.EventHandler(this.btnvaciar_Click);
            // 
            // btnverelemento
            // 
            this.btnverelemento.Location = new System.Drawing.Point(161, 196);
            this.btnverelemento.Name = "btnverelemento";
            this.btnverelemento.Size = new System.Drawing.Size(109, 23);
            this.btnverelemento.TabIndex = 9;
            this.btnverelemento.Text = "Ver indice";
            this.btnverelemento.UseVisualStyleBackColor = true;
            this.btnverelemento.Click += new System.EventHandler(this.btnverelemento_Click);
            // 
            // btnindice
            // 
            this.btnindice.Location = new System.Drawing.Point(161, 167);
            this.btnindice.Name = "btnindice";
            this.btnindice.Size = new System.Drawing.Size(109, 23);
            this.btnindice.TabIndex = 10;
            this.btnindice.Text = "Ver elemento";
            this.btnindice.UseVisualStyleBackColor = true;
            this.btnindice.Click += new System.EventHandler(this.btnindice_Click);
            // 
            // Combobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnindice);
            this.Controls.Add(this.btnverelemento);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnvaciar);
            this.Controls.Add(this.CMB);
            this.Name = "Combobox";
            this.Text = "Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.Button btnverelemento;
        private System.Windows.Forms.Button btnindice;
    }
}