﻿namespace PokemonApp
{
    partial class frmPrincipal
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
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.picboxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregarPpal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.Location = new System.Drawing.Point(12, 23);
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.Size = new System.Drawing.Size(722, 285);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // picboxPokemon
            // 
            this.picboxPokemon.Location = new System.Drawing.Point(769, 23);
            this.picboxPokemon.Name = "picboxPokemon";
            this.picboxPokemon.Size = new System.Drawing.Size(264, 285);
            this.picboxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPokemon.TabIndex = 1;
            this.picboxPokemon.TabStop = false;
            // 
            // btnAgregarPpal
            // 
            this.btnAgregarPpal.Location = new System.Drawing.Point(12, 315);
            this.btnAgregarPpal.Name = "btnAgregarPpal";
            this.btnAgregarPpal.Size = new System.Drawing.Size(137, 36);
            this.btnAgregarPpal.TabIndex = 2;
            this.btnAgregarPpal.Text = "Agregar Pokemon";
            this.btnAgregarPpal.UseVisualStyleBackColor = true;
            this.btnAgregarPpal.Click += new System.EventHandler(this.btnAgregarPpal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 363);
            this.Controls.Add(this.btnAgregarPpal);
            this.Controls.Add(this.picboxPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox picboxPokemon;
        private System.Windows.Forms.Button btnAgregarPpal;
    }
}
