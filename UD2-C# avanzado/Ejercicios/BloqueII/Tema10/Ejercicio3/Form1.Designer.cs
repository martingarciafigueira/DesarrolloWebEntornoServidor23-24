namespace Ejercicio3
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
            this.lstVideojuegos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCreador = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtNumTemporadas = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSeries = new System.Windows.Forms.ListBox();
            this.btnCrearVideojuego = new System.Windows.Forms.Button();
            this.btnCrearSerie = new System.Windows.Forms.Button();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.txtGenero2 = new System.Windows.Forms.TextBox();
            this.txtHorasEstimadas = new System.Windows.Forms.TextBox();
            this.txtTitulo2 = new System.Windows.Forms.TextBox();
            this.Compañía = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVideojuegos
            // 
            this.lstVideojuegos.FormattingEnabled = true;
            this.lstVideojuegos.Location = new System.Drawing.Point(607, 91);
            this.lstVideojuegos.Name = "lstVideojuegos";
            this.lstVideojuegos.Size = new System.Drawing.Size(105, 199);
            this.lstVideojuegos.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Entregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCreador
            // 
            this.txtCreador.Location = new System.Drawing.Point(234, 148);
            this.txtCreador.Name = "txtCreador";
            this.txtCreador.Size = new System.Drawing.Size(100, 20);
            this.txtCreador.TabIndex = 31;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(234, 119);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 30;
            // 
            // txtNumTemporadas
            // 
            this.txtNumTemporadas.Location = new System.Drawing.Point(234, 91);
            this.txtNumTemporadas.Name = "txtNumTemporadas";
            this.txtNumTemporadas.Size = new System.Drawing.Size(100, 20);
            this.txtNumTemporadas.TabIndex = 29;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(234, 60);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Creador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero temporadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Titulo";
            // 
            // lstSeries
            // 
            this.lstSeries.FormattingEnabled = true;
            this.lstSeries.Location = new System.Drawing.Point(434, 91);
            this.lstSeries.Name = "lstSeries";
            this.lstSeries.Size = new System.Drawing.Size(105, 199);
            this.lstSeries.TabIndex = 22;
            // 
            // btnCrearVideojuego
            // 
            this.btnCrearVideojuego.Location = new System.Drawing.Point(160, 395);
            this.btnCrearVideojuego.Name = "btnCrearVideojuego";
            this.btnCrearVideojuego.Size = new System.Drawing.Size(130, 23);
            this.btnCrearVideojuego.TabIndex = 21;
            this.btnCrearVideojuego.Text = "Crear videojuego";
            this.btnCrearVideojuego.UseVisualStyleBackColor = true;
            this.btnCrearVideojuego.Click += new System.EventHandler(this.btnCrearVideojuego_Click);
            // 
            // btnCrearSerie
            // 
            this.btnCrearSerie.Location = new System.Drawing.Point(169, 191);
            this.btnCrearSerie.Name = "btnCrearSerie";
            this.btnCrearSerie.Size = new System.Drawing.Size(105, 23);
            this.btnCrearSerie.TabIndex = 20;
            this.btnCrearSerie.Text = "Crear serie";
            this.btnCrearSerie.UseVisualStyleBackColor = true;
            this.btnCrearSerie.Click += new System.EventHandler(this.btnCrearSerie_Click);
            // 
            // txtCompañia
            // 
            this.txtCompañia.Location = new System.Drawing.Point(234, 351);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(100, 20);
            this.txtCompañia.TabIndex = 46;
            // 
            // txtGenero2
            // 
            this.txtGenero2.Location = new System.Drawing.Point(234, 322);
            this.txtGenero2.Name = "txtGenero2";
            this.txtGenero2.Size = new System.Drawing.Size(100, 20);
            this.txtGenero2.TabIndex = 45;
            // 
            // txtHorasEstimadas
            // 
            this.txtHorasEstimadas.Location = new System.Drawing.Point(234, 294);
            this.txtHorasEstimadas.Name = "txtHorasEstimadas";
            this.txtHorasEstimadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasEstimadas.TabIndex = 44;
            // 
            // txtTitulo2
            // 
            this.txtTitulo2.Location = new System.Drawing.Point(234, 263);
            this.txtTitulo2.Name = "txtTitulo2";
            this.txtTitulo2.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo2.TabIndex = 43;
            // 
            // Compañía
            // 
            this.Compañía.AutoSize = true;
            this.Compañía.Location = new System.Drawing.Point(93, 354);
            this.Compañía.Name = "Compañía";
            this.Compañía.Size = new System.Drawing.Size(54, 13);
            this.Compañía.TabIndex = 42;
            this.Compañía.Text = "Compañia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Horas estimadas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Titulo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Entregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Contar entregados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 43);
            this.button4.TabIndex = 49;
            this.button4.Text = "Videojuego y serie más largos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.txtGenero2);
            this.Controls.Add(this.txtHorasEstimadas);
            this.Controls.Add(this.txtTitulo2);
            this.Controls.Add(this.Compañía);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstVideojuegos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCreador);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNumTemporadas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSeries);
            this.Controls.Add(this.btnCrearVideojuego);
            this.Controls.Add(this.btnCrearSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVideojuegos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCreador;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNumTemporadas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSeries;
        private System.Windows.Forms.Button btnCrearVideojuego;
        private System.Windows.Forms.Button btnCrearSerie;
        private System.Windows.Forms.TextBox txtCompañia;
        private System.Windows.Forms.TextBox txtGenero2;
        private System.Windows.Forms.TextBox txtHorasEstimadas;
        private System.Windows.Forms.TextBox txtTitulo2;
        private System.Windows.Forms.Label Compañía;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

