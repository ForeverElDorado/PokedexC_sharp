namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.imagenPokemon = new System.Windows.Forms.PictureBox();
            this.Izquierda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.BotonTablaPokemon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AreaPokemon = new System.Windows.Forms.Label();
            this.EspeciePokemon = new System.Windows.Forms.Label();
            this.Tipo1Pokemon = new System.Windows.Forms.Label();
            this.Tipo2Pokemon = new System.Windows.Forms.Label();
            this.decoracion1 = new System.Windows.Forms.Label();
            this.Ataque1Pokemon = new System.Windows.Forms.Label();
            this.Ataque2Pokemon = new System.Windows.Forms.Label();
            this.Ataque4Pokemon = new System.Windows.Forms.Label();
            this.Ataque3Pokemon = new System.Windows.Forms.Label();
            this.IdPokemon = new System.Windows.Forms.Label();
            this.DescripcionPokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.Location = new System.Drawing.Point(126, 154);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(152, 140);
            this.imagenPokemon.TabIndex = 0;
            this.imagenPokemon.TabStop = false;
            // 
            // Izquierda
            // 
            this.Izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquierda.Location = new System.Drawing.Point(103, 359);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(74, 30);
            this.Izquierda.TabIndex = 1;
            this.Izquierda.Text = "<=";
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Derecha
            // 
            this.Derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.Location = new System.Drawing.Point(183, 359);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(74, 30);
            this.Derecha.TabIndex = 2;
            this.Derecha.Text = "=>";
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.ForeColor = System.Drawing.Color.White;
            this.nombrePokemon.Location = new System.Drawing.Point(221, 306);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(111, 36);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonTablaPokemon
            // 
            this.BotonTablaPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BotonTablaPokemon.Image = global::PokedexC_sharp.Properties.Resources.icons8_pokedex;
            this.BotonTablaPokemon.Location = new System.Drawing.Point(620, 409);
            this.BotonTablaPokemon.Name = "BotonTablaPokemon";
            this.BotonTablaPokemon.Size = new System.Drawing.Size(131, 55);
            this.BotonTablaPokemon.TabIndex = 4;
            this.BotonTablaPokemon.UseVisualStyleBackColor = false;
            this.BotonTablaPokemon.Click += new System.EventHandler(this.botonTablaPokemon);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PokedexC_sharp.Properties.Resources.Pokedex;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AreaPokemon
            // 
            this.AreaPokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AreaPokemon.ForeColor = System.Drawing.Color.White;
            this.AreaPokemon.Location = new System.Drawing.Point(86, 306);
            this.AreaPokemon.Name = "AreaPokemon";
            this.AreaPokemon.Size = new System.Drawing.Size(111, 36);
            this.AreaPokemon.TabIndex = 6;
            this.AreaPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EspeciePokemon
            // 
            this.EspeciePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EspeciePokemon.ForeColor = System.Drawing.Color.White;
            this.EspeciePokemon.Location = new System.Drawing.Point(483, 409);
            this.EspeciePokemon.Name = "EspeciePokemon";
            this.EspeciePokemon.Size = new System.Drawing.Size(124, 55);
            this.EspeciePokemon.TabIndex = 7;
            this.EspeciePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tipo1Pokemon
            // 
            this.Tipo1Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipo1Pokemon.ForeColor = System.Drawing.Color.White;
            this.Tipo1Pokemon.Location = new System.Drawing.Point(483, 350);
            this.Tipo1Pokemon.Name = "Tipo1Pokemon";
            this.Tipo1Pokemon.Size = new System.Drawing.Size(58, 39);
            this.Tipo1Pokemon.TabIndex = 9;
            this.Tipo1Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tipo2Pokemon
            // 
            this.Tipo2Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tipo2Pokemon.ForeColor = System.Drawing.Color.White;
            this.Tipo2Pokemon.Location = new System.Drawing.Point(547, 350);
            this.Tipo2Pokemon.Name = "Tipo2Pokemon";
            this.Tipo2Pokemon.Size = new System.Drawing.Size(58, 39);
            this.Tipo2Pokemon.TabIndex = 10;
            this.Tipo2Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decoracion1
            // 
            this.decoracion1.BackColor = System.Drawing.Color.Blue;
            this.decoracion1.ForeColor = System.Drawing.Color.White;
            this.decoracion1.Location = new System.Drawing.Point(483, 255);
            this.decoracion1.Name = "decoracion1";
            this.decoracion1.Size = new System.Drawing.Size(268, 75);
            this.decoracion1.TabIndex = 11;
            this.decoracion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ataque1Pokemon
            // 
            this.Ataque1Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ataque1Pokemon.ForeColor = System.Drawing.Color.White;
            this.Ataque1Pokemon.Location = new System.Drawing.Point(483, 255);
            this.Ataque1Pokemon.Name = "Ataque1Pokemon";
            this.Ataque1Pokemon.Size = new System.Drawing.Size(124, 36);
            this.Ataque1Pokemon.TabIndex = 12;
            this.Ataque1Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ataque2Pokemon
            // 
            this.Ataque2Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ataque2Pokemon.ForeColor = System.Drawing.Color.White;
            this.Ataque2Pokemon.Location = new System.Drawing.Point(483, 294);
            this.Ataque2Pokemon.Name = "Ataque2Pokemon";
            this.Ataque2Pokemon.Size = new System.Drawing.Size(124, 36);
            this.Ataque2Pokemon.TabIndex = 13;
            this.Ataque2Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ataque4Pokemon
            // 
            this.Ataque4Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ataque4Pokemon.ForeColor = System.Drawing.Color.White;
            this.Ataque4Pokemon.Location = new System.Drawing.Point(627, 294);
            this.Ataque4Pokemon.Name = "Ataque4Pokemon";
            this.Ataque4Pokemon.Size = new System.Drawing.Size(124, 36);
            this.Ataque4Pokemon.TabIndex = 14;
            this.Ataque4Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ataque3Pokemon
            // 
            this.Ataque3Pokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ataque3Pokemon.ForeColor = System.Drawing.Color.White;
            this.Ataque3Pokemon.Location = new System.Drawing.Point(627, 255);
            this.Ataque3Pokemon.Name = "Ataque3Pokemon";
            this.Ataque3Pokemon.Size = new System.Drawing.Size(124, 36);
            this.Ataque3Pokemon.TabIndex = 15;
            this.Ataque3Pokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdPokemon
            // 
            this.IdPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IdPokemon.ForeColor = System.Drawing.Color.Black;
            this.IdPokemon.Location = new System.Drawing.Point(284, 256);
            this.IdPokemon.Name = "IdPokemon";
            this.IdPokemon.Size = new System.Drawing.Size(36, 35);
            this.IdPokemon.TabIndex = 8;
            this.IdPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescripcionPokemon
            // 
            this.DescripcionPokemon.BackColor = System.Drawing.Color.Lime;
            this.DescripcionPokemon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionPokemon.ForeColor = System.Drawing.Color.Black;
            this.DescripcionPokemon.Location = new System.Drawing.Point(483, 154);
            this.DescripcionPokemon.Name = "DescripcionPokemon";
            this.DescripcionPokemon.Size = new System.Drawing.Size(268, 91);
            this.DescripcionPokemon.TabIndex = 16;
            this.DescripcionPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 500);
            this.Controls.Add(this.DescripcionPokemon);
            this.Controls.Add(this.Ataque3Pokemon);
            this.Controls.Add(this.Ataque4Pokemon);
            this.Controls.Add(this.Ataque2Pokemon);
            this.Controls.Add(this.Ataque1Pokemon);
            this.Controls.Add(this.decoracion1);
            this.Controls.Add(this.Tipo2Pokemon);
            this.Controls.Add(this.Tipo1Pokemon);
            this.Controls.Add(this.IdPokemon);
            this.Controls.Add(this.EspeciePokemon);
            this.Controls.Add(this.AreaPokemon);
            this.Controls.Add(this.BotonTablaPokemon);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.Izquierda);
            this.Controls.Add(this.imagenPokemon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPokemon;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button BotonTablaPokemon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AreaPokemon;
        private System.Windows.Forms.Label EspeciePokemon;
        private System.Windows.Forms.Label Tipo1Pokemon;
        private System.Windows.Forms.Label Tipo2Pokemon;
        private System.Windows.Forms.Label decoracion1;
        private System.Windows.Forms.Label Ataque1Pokemon;
        private System.Windows.Forms.Label Ataque2Pokemon;
        private System.Windows.Forms.Label Ataque4Pokemon;
        private System.Windows.Forms.Label Ataque3Pokemon;
        private System.Windows.Forms.Label IdPokemon;
        private System.Windows.Forms.Label DescripcionPokemon;
    }
}

