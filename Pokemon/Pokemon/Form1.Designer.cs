﻿namespace Pokemon
{
    partial class Form1
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
            this.cbPokeNames = new System.Windows.Forms.ComboBox();
            this.lblPlayerPokemon = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPokeNames
            // 
            this.cbPokeNames.FormattingEnabled = true;
            this.cbPokeNames.Location = new System.Drawing.Point(83, 29);
            this.cbPokeNames.Name = "cbPokeNames";
            this.cbPokeNames.Size = new System.Drawing.Size(121, 21);
            this.cbPokeNames.TabIndex = 0;
            // 
            // lblPlayerPokemon
            // 
            this.lblPlayerPokemon.AutoSize = true;
            this.lblPlayerPokemon.Location = new System.Drawing.Point(23, 32);
            this.lblPlayerPokemon.Name = "lblPlayerPokemon";
            this.lblPlayerPokemon.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerPokemon.TabIndex = 1;
            this.lblPlayerPokemon.Text = "label1";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(184, 204);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayerPokemon);
            this.Controls.Add(this.cbPokeNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPokeNames;
        private System.Windows.Forms.Label lblPlayerPokemon;
        private System.Windows.Forms.Button btnPlay;
    }
}

