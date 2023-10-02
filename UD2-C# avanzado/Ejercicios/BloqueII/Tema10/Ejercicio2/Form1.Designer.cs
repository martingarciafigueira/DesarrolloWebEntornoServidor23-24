namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearLavadora = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstElectrodomesticos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtConsumoEnergetico = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.cbTDT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearLavadora
            // 
            this.btnCrearLavadora.Location = new System.Drawing.Point(82, 251);
            this.btnCrearLavadora.Name = "btnCrearLavadora";
            this.btnCrearLavadora.Size = new System.Drawing.Size(105, 23);
            this.btnCrearLavadora.TabIndex = 0;
            this.btnCrearLavadora.Text = "Crear lavadora";
            this.btnCrearLavadora.UseVisualStyleBackColor = true;
            this.btnCrearLavadora.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Crear televisión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstElectrodomesticos
            // 
            this.lstElectrodomesticos.FormattingEnabled = true;
            this.lstElectrodomesticos.Location = new System.Drawing.Point(420, 37);
            this.lstElectrodomesticos.Name = "lstElectrodomesticos";
            this.lstElectrodomesticos.Size = new System.Drawing.Size(308, 342);
            this.lstElectrodomesticos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Precio base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consumo energético";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carga";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(220, 6);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioBase.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(220, 37);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // txtConsumoEnergetico
            // 
            this.txtConsumoEnergetico.Location = new System.Drawing.Point(220, 65);
            this.txtConsumoEnergetico.Name = "txtConsumoEnergetico";
            this.txtConsumoEnergetico.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoEnergetico.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(220, 94);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 12;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(220, 127);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resolución";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sintonizador TDT";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(220, 163);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(100, 20);
            this.txtResolucion.TabIndex = 16;
            // 
            // cbTDT
            // 
            this.cbTDT.FormattingEnabled = true;
            this.cbTDT.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbTDT.Location = new System.Drawing.Point(220, 203);
            this.cbTDT.Name = "cbTDT";
            this.cbTDT.Size = new System.Drawing.Size(100, 21);
            this.cbTDT.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular precio final";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Calcular suma total";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTDT);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtConsumoEnergetico);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstElectrodomesticos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearLavadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearLavadora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstElectrodomesticos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtConsumoEnergetico;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.ComboBox cbTDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

