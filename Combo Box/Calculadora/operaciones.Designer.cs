namespace Calculadora
{
    partial class operaciones
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDivision = new System.Windows.Forms.RadioButton();
            this.radiomultiplicacion = new System.Windows.Forms.RadioButton();
            this.radioresta = new System.Windows.Forms.RadioButton();
            this.radiosuma = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los valores";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(13, 36);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(166, 33);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(132, 36);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(0, 13);
            this.lblop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(301, 36);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDivision);
            this.groupBox1.Controls.Add(this.radiomultiplicacion);
            this.groupBox1.Controls.Add(this.radioresta);
            this.groupBox1.Controls.Add(this.radiosuma);
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // radioDivision
            // 
            this.radioDivision.AutoSize = true;
            this.radioDivision.Location = new System.Drawing.Point(19, 92);
            this.radioDivision.Name = "radioDivision";
            this.radioDivision.Size = new System.Drawing.Size(62, 17);
            this.radioDivision.TabIndex = 3;
            this.radioDivision.TabStop = true;
            this.radioDivision.Text = "Division";
            this.radioDivision.UseVisualStyleBackColor = true;
            this.radioDivision.CheckedChanged += new System.EventHandler(this.radioDivision_CheckedChanged);
            // 
            // radiomultiplicacion
            // 
            this.radiomultiplicacion.AutoSize = true;
            this.radiomultiplicacion.Location = new System.Drawing.Point(19, 68);
            this.radiomultiplicacion.Name = "radiomultiplicacion";
            this.radiomultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.radiomultiplicacion.TabIndex = 2;
            this.radiomultiplicacion.TabStop = true;
            this.radiomultiplicacion.Text = "Multiplicacion";
            this.radiomultiplicacion.UseVisualStyleBackColor = true;
            this.radiomultiplicacion.CheckedChanged += new System.EventHandler(this.radiomultiplicacion_CheckedChanged);
            // 
            // radioresta
            // 
            this.radioresta.AutoSize = true;
            this.radioresta.Location = new System.Drawing.Point(19, 44);
            this.radioresta.Name = "radioresta";
            this.radioresta.Size = new System.Drawing.Size(53, 17);
            this.radioresta.TabIndex = 1;
            this.radioresta.TabStop = true;
            this.radioresta.Text = "Resta";
            this.radioresta.UseVisualStyleBackColor = true;
            this.radioresta.CheckedChanged += new System.EventHandler(this.radioresta_CheckedChanged);
            // 
            // radiosuma
            // 
            this.radiosuma.AutoSize = true;
            this.radiosuma.Location = new System.Drawing.Point(19, 20);
            this.radiosuma.Name = "radiosuma";
            this.radiosuma.Size = new System.Drawing.Size(52, 17);
            this.radiosuma.TabIndex = 0;
            this.radiosuma.TabStop = true;
            this.radiosuma.Text = "Suma";
            this.radiosuma.UseVisualStyleBackColor = true;
            this.radiosuma.CheckedChanged += new System.EventHandler(this.radiosuma_CheckedChanged);
            // 
            // operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 209);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblop);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label1);
            this.Name = "operaciones";
            this.Text = "operaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDivision;
        private System.Windows.Forms.RadioButton radiomultiplicacion;
        private System.Windows.Forms.RadioButton radioresta;
        private System.Windows.Forms.RadioButton radiosuma;
    }
}