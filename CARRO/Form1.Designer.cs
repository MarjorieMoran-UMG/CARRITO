
namespace CARRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPrincipal = new System.Windows.Forms.Button();
            this.buttonYaris = new System.Windows.Forms.Button();
            this.buttonHilux = new System.Windows.Forms.Button();
            this.buttonRav = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonFreno = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonPausa = new System.Windows.Forms.Button();
            this.buttonPalanca = new System.Windows.Forms.Button();
            this.labelPalanca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYARIS = new System.Windows.Forms.Label();
            this.labelHILUX = new System.Windows.Forms.Label();
            this.labelRAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrincipal
            // 
            this.buttonPrincipal.BackColor = System.Drawing.Color.Firebrick;
            this.buttonPrincipal.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrincipal.ForeColor = System.Drawing.Color.White;
            this.buttonPrincipal.Location = new System.Drawing.Point(12, 14);
            this.buttonPrincipal.Name = "buttonPrincipal";
            this.buttonPrincipal.Size = new System.Drawing.Size(139, 55);
            this.buttonPrincipal.TabIndex = 0;
            this.buttonPrincipal.Text = "Elegir Carro";
            this.buttonPrincipal.UseVisualStyleBackColor = false;
            this.buttonPrincipal.Click += new System.EventHandler(this.buttonPrincipal_Click);
            // 
            // buttonYaris
            // 
            this.buttonYaris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYaris.BackgroundImage")));
            this.buttonYaris.Location = new System.Drawing.Point(692, 12);
            this.buttonYaris.Name = "buttonYaris";
            this.buttonYaris.Size = new System.Drawing.Size(230, 151);
            this.buttonYaris.TabIndex = 1;
            this.buttonYaris.UseVisualStyleBackColor = true;
            this.buttonYaris.Visible = false;
            this.buttonYaris.Click += new System.EventHandler(this.buttonYaris_Click);
            // 
            // buttonHilux
            // 
            this.buttonHilux.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHilux.BackgroundImage")));
            this.buttonHilux.Location = new System.Drawing.Point(509, 172);
            this.buttonHilux.Name = "buttonHilux";
            this.buttonHilux.Size = new System.Drawing.Size(229, 151);
            this.buttonHilux.TabIndex = 2;
            this.buttonHilux.UseVisualStyleBackColor = true;
            this.buttonHilux.Visible = false;
            this.buttonHilux.Click += new System.EventHandler(this.buttonHilux_Click);
            // 
            // buttonRav
            // 
            this.buttonRav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRav.BackgroundImage")));
            this.buttonRav.Location = new System.Drawing.Point(694, 335);
            this.buttonRav.Name = "buttonRav";
            this.buttonRav.Size = new System.Drawing.Size(228, 150);
            this.buttonRav.TabIndex = 3;
            this.buttonRav.UseVisualStyleBackColor = true;
            this.buttonRav.Visible = false;
            this.buttonRav.Click += new System.EventHandler(this.buttonRav_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.DimGray;
            this.buttonEncender.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.Color.White;
            this.buttonEncender.Location = new System.Drawing.Point(12, 94);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(139, 55);
            this.buttonEncender.TabIndex = 4;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.White;
            this.labelEstado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.Black;
            this.labelEstado.Location = new System.Drawing.Point(186, 112);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(14, 19);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = ".";
            this.labelEstado.Visible = false;
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.DimGray;
            this.buttonAcelerar.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.ForeColor = System.Drawing.Color.White;
            this.buttonAcelerar.Location = new System.Drawing.Point(12, 155);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(139, 55);
            this.buttonAcelerar.TabIndex = 6;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.BackColor = System.Drawing.Color.White;
            this.labelEstadoVelocidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoVelocidad.ForeColor = System.Drawing.Color.Black;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(186, 159);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(18, 19);
            this.labelEstadoVelocidad.TabIndex = 7;
            this.labelEstadoVelocidad.Text = " .";
            this.labelEstadoVelocidad.Visible = false;
            // 
            // buttonFreno
            // 
            this.buttonFreno.BackColor = System.Drawing.Color.DimGray;
            this.buttonFreno.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFreno.ForeColor = System.Drawing.Color.White;
            this.buttonFreno.Location = new System.Drawing.Point(12, 216);
            this.buttonFreno.Name = "buttonFreno";
            this.buttonFreno.Size = new System.Drawing.Size(139, 55);
            this.buttonFreno.TabIndex = 8;
            this.buttonFreno.Text = "Freno";
            this.buttonFreno.UseVisualStyleBackColor = false;
            this.buttonFreno.Visible = false;
            this.buttonFreno.Click += new System.EventHandler(this.buttonFreno_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.Color.White;
            this.labelCambio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.ForeColor = System.Drawing.Color.Black;
            this.labelCambio.Location = new System.Drawing.Point(186, 188);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(18, 19);
            this.labelCambio.TabIndex = 9;
            this.labelCambio.Text = " .";
            this.labelCambio.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(15, 390);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(362, 58);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReproducir.BackgroundImage")));
            this.buttonReproducir.Location = new System.Drawing.Point(18, 414);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(50, 53);
            this.buttonReproducir.TabIndex = 11;
            this.buttonReproducir.UseVisualStyleBackColor = true;
            this.buttonReproducir.Visible = false;
            this.buttonReproducir.Click += new System.EventHandler(this.buttonReproducir_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonParar.BackgroundImage")));
            this.buttonParar.Location = new System.Drawing.Point(324, 414);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(50, 53);
            this.buttonParar.TabIndex = 12;
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Visible = false;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonPausa
            // 
            this.buttonPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPausa.BackgroundImage")));
            this.buttonPausa.Location = new System.Drawing.Point(75, 414);
            this.buttonPausa.Name = "buttonPausa";
            this.buttonPausa.Size = new System.Drawing.Size(50, 53);
            this.buttonPausa.TabIndex = 13;
            this.buttonPausa.UseVisualStyleBackColor = true;
            this.buttonPausa.Visible = false;
            this.buttonPausa.Click += new System.EventHandler(this.buttonPausa_Click);
            // 
            // buttonPalanca
            // 
            this.buttonPalanca.BackColor = System.Drawing.Color.DimGray;
            this.buttonPalanca.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPalanca.ForeColor = System.Drawing.Color.White;
            this.buttonPalanca.Location = new System.Drawing.Point(12, 277);
            this.buttonPalanca.Name = "buttonPalanca";
            this.buttonPalanca.Size = new System.Drawing.Size(139, 55);
            this.buttonPalanca.TabIndex = 14;
            this.buttonPalanca.Text = "Cambio Velocidad";
            this.buttonPalanca.UseVisualStyleBackColor = false;
            this.buttonPalanca.Visible = false;
            this.buttonPalanca.Click += new System.EventHandler(this.buttonPalanca_Click);
            // 
            // labelPalanca
            // 
            this.labelPalanca.AutoSize = true;
            this.labelPalanca.BackColor = System.Drawing.Color.White;
            this.labelPalanca.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalanca.ForeColor = System.Drawing.Color.Black;
            this.labelPalanca.Location = new System.Drawing.Point(186, 299);
            this.labelPalanca.Name = "labelPalanca";
            this.labelPalanca.Size = new System.Drawing.Size(18, 19);
            this.labelPalanca.TabIndex = 15;
            this.labelPalanca.Text = " .";
            this.labelPalanca.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 80);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Peace Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exposición 2021";
            // 
            // labelYARIS
            // 
            this.labelYARIS.AutoSize = true;
            this.labelYARIS.BackColor = System.Drawing.Color.Transparent;
            this.labelYARIS.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYARIS.ForeColor = System.Drawing.Color.LightGray;
            this.labelYARIS.Location = new System.Drawing.Point(623, 77);
            this.labelYARIS.Name = "labelYARIS";
            this.labelYARIS.Size = new System.Drawing.Size(65, 23);
            this.labelYARIS.TabIndex = 18;
            this.labelYARIS.Text = "YARIS";
            this.labelYARIS.Visible = false;
            // 
            // labelHILUX
            // 
            this.labelHILUX.AutoSize = true;
            this.labelHILUX.BackColor = System.Drawing.Color.Transparent;
            this.labelHILUX.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHILUX.ForeColor = System.Drawing.Color.LightGray;
            this.labelHILUX.Location = new System.Drawing.Point(744, 233);
            this.labelHILUX.Name = "labelHILUX";
            this.labelHILUX.Size = new System.Drawing.Size(69, 23);
            this.labelHILUX.TabIndex = 19;
            this.labelHILUX.Text = "HILUX";
            this.labelHILUX.Visible = false;
            // 
            // labelRAV
            // 
            this.labelRAV.AutoSize = true;
            this.labelRAV.BackColor = System.Drawing.Color.Transparent;
            this.labelRAV.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAV.ForeColor = System.Drawing.Color.LightGray;
            this.labelRAV.Location = new System.Drawing.Point(619, 396);
            this.labelRAV.Name = "labelRAV";
            this.labelRAV.Size = new System.Drawing.Size(58, 23);
            this.labelRAV.TabIndex = 20;
            this.labelRAV.Text = "RAV4";
            this.labelRAV.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.labelRAV);
            this.Controls.Add(this.labelHILUX);
            this.Controls.Add(this.labelYARIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPalanca);
            this.Controls.Add(this.buttonPalanca);
            this.Controls.Add(this.buttonPausa);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonReproducir);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.buttonFreno);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonRav);
            this.Controls.Add(this.buttonHilux);
            this.Controls.Add(this.buttonYaris);
            this.Controls.Add(this.buttonPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrincipal;
        private System.Windows.Forms.Button buttonYaris;
        private System.Windows.Forms.Button buttonHilux;
        private System.Windows.Forms.Button buttonRav;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonFreno;
        private System.Windows.Forms.Label labelCambio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonReproducir;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonPausa;
        private System.Windows.Forms.Button buttonPalanca;
        private System.Windows.Forms.Label labelPalanca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYARIS;
        private System.Windows.Forms.Label labelHILUX;
        private System.Windows.Forms.Label labelRAV;
    }
}

