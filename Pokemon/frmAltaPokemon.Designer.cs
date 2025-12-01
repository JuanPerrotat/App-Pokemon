namespace winform_app
{
    partial class frmAltaPokemon
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
            this.lblNumeroPokemon = new System.Windows.Forms.Label();
            this.lblNombrePokemon = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.txtbNombrePokemon = new System.Windows.Forms.TextBox();
            this.txtbDescripcionPokemon = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNumeroPokemon
            // 
            this.lblNumeroPokemon.AutoSize = true;
            this.lblNumeroPokemon.Location = new System.Drawing.Point(28, 52);
            this.lblNumeroPokemon.Name = "lblNumeroPokemon";
            this.lblNumeroPokemon.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPokemon.TabIndex = 0;
            this.lblNumeroPokemon.Text = "Número:";
            // 
            // lblNombrePokemon
            // 
            this.lblNombrePokemon.AutoSize = true;
            this.lblNombrePokemon.Location = new System.Drawing.Point(28, 106);
            this.lblNombrePokemon.Name = "lblNombrePokemon";
            this.lblNombrePokemon.Size = new System.Drawing.Size(47, 13);
            this.lblNombrePokemon.TabIndex = 1;
            this.lblNombrePokemon.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 163);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(100, 49);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(266, 20);
            this.txtbNumero.TabIndex = 3;
            // 
            // txtbNombrePokemon
            // 
            this.txtbNombrePokemon.Location = new System.Drawing.Point(100, 103);
            this.txtbNombrePokemon.Name = "txtbNombrePokemon";
            this.txtbNombrePokemon.Size = new System.Drawing.Size(266, 20);
            this.txtbNombrePokemon.TabIndex = 4;
            // 
            // txtbDescripcionPokemon
            // 
            this.txtbDescripcionPokemon.Location = new System.Drawing.Point(100, 160);
            this.txtbDescripcionPokemon.Name = "txtbDescripcionPokemon";
            this.txtbDescripcionPokemon.Size = new System.Drawing.Size(266, 20);
            this.txtbDescripcionPokemon.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(100, 402);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 402);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 217);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(28, 270);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(54, 13);
            this.lblDebilidad.TabIndex = 10;
            this.lblDebilidad.Text = "Debilidad:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(100, 214);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(266, 21);
            this.cboTipo.TabIndex = 11;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(100, 267);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(266, 21);
            this.cboDebilidad.TabIndex = 12;
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 507);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbDescripcionPokemon);
            this.Controls.Add(this.txtbNombrePokemon);
            this.Controls.Add(this.txtbNumero);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombrePokemon);
            this.Controls.Add(this.lblNumeroPokemon);
            this.MinimumSize = new System.Drawing.Size(476, 546);
            this.Name = "frmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroPokemon;
        private System.Windows.Forms.Label lblNombrePokemon;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.TextBox txtbNombrePokemon;
        private System.Windows.Forms.TextBox txtbDescripcionPokemon;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboDebilidad;
    }
}