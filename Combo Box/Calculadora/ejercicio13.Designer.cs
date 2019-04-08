namespace Calculadora
{
    partial class ejercicio13
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
            this.radiohombre = new System.Windows.Forms.RadioButton();
            this.radiomujer = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.grupBedad = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grupBedad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiohombre
            // 
            this.radiohombre.AutoSize = true;
            this.radiohombre.Location = new System.Drawing.Point(22, 19);
            this.radiohombre.Name = "radiohombre";
            this.radiohombre.Size = new System.Drawing.Size(62, 17);
            this.radiohombre.TabIndex = 2;
            this.radiohombre.TabStop = true;
            this.radiohombre.Text = "Hombre";
            this.radiohombre.UseVisualStyleBackColor = true;
            this.radiohombre.CheckedChanged += new System.EventHandler(this.radiohombre_CheckedChanged);
            // 
            // radiomujer
            // 
            this.radiomujer.AutoSize = true;
            this.radiomujer.Location = new System.Drawing.Point(134, 19);
            this.radiomujer.Name = "radiomujer";
            this.radiomujer.Size = new System.Drawing.Size(51, 17);
            this.radiomujer.TabIndex = 3;
            this.radiomujer.TabStop = true;
            this.radiomujer.Text = "Mujer";
            this.radiomujer.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "34-50";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "18-30";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(23, 62);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(94, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "51 años o mas";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // grupBedad
            // 
            this.grupBedad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grupBedad.Controls.Add(this.radioButton3);
            this.grupBedad.Controls.Add(this.radioButton5);
            this.grupBedad.Controls.Add(this.radioButton4);
            this.grupBedad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grupBedad.Location = new System.Drawing.Point(30, 118);
            this.grupBedad.Name = "grupBedad";
            this.grupBedad.Size = new System.Drawing.Size(200, 100);
            this.grupBedad.TabIndex = 7;
            this.grupBedad.TabStop = false;
            this.grupBedad.Text = "Edad";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Red;
            this.groupBox2.Controls.Add(this.radiomujer);
            this.groupBox2.Controls.Add(this.radiohombre);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(31, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 47);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // ejercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupBedad);
            this.Name = "ejercicio13";
            this.Text = "ejercicio13";
            this.grupBedad.ResumeLayout(false);
            this.grupBedad.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radiohombre;
        private System.Windows.Forms.RadioButton radiomujer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox grupBedad;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}