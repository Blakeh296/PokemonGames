namespace PokemonGameAttempt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQuickGame = new System.Windows.Forms.Button();
            this.pbFirstPokeball = new System.Windows.Forms.PictureBox();
            this.pbSecondPokeball = new System.Windows.Forms.PictureBox();
            this.pbCoolSquirtle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSqirtlePick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstPokeball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondPokeball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoolSquirtle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuickGame
            // 
            this.btnQuickGame.Location = new System.Drawing.Point(330, 329);
            this.btnQuickGame.Name = "btnQuickGame";
            this.btnQuickGame.Size = new System.Drawing.Size(167, 23);
            this.btnQuickGame.TabIndex = 0;
            this.btnQuickGame.Text = "QuickGame";
            this.btnQuickGame.UseVisualStyleBackColor = true;
            this.btnQuickGame.Click += new System.EventHandler(this.btnQuickGame_Click_1);
            // 
            // pbFirstPokeball
            // 
            this.pbFirstPokeball.Image = ((System.Drawing.Image)(resources.GetObject("pbFirstPokeball.Image")));
            this.pbFirstPokeball.Location = new System.Drawing.Point(257, 167);
            this.pbFirstPokeball.Name = "pbFirstPokeball";
            this.pbFirstPokeball.Size = new System.Drawing.Size(118, 105);
            this.pbFirstPokeball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstPokeball.TabIndex = 1;
            this.pbFirstPokeball.TabStop = false;
            this.pbFirstPokeball.Visible = false;
            this.pbFirstPokeball.MouseHover += new System.EventHandler(this.pbFirstPokeball_MouseHover);
            // 
            // pbSecondPokeball
            // 
            this.pbSecondPokeball.Image = ((System.Drawing.Image)(resources.GetObject("pbSecondPokeball.Image")));
            this.pbSecondPokeball.Location = new System.Drawing.Point(431, 167);
            this.pbSecondPokeball.Name = "pbSecondPokeball";
            this.pbSecondPokeball.Size = new System.Drawing.Size(118, 105);
            this.pbSecondPokeball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondPokeball.TabIndex = 2;
            this.pbSecondPokeball.TabStop = false;
            this.pbSecondPokeball.Visible = false;
            // 
            // pbCoolSquirtle
            // 
            this.pbCoolSquirtle.Image = ((System.Drawing.Image)(resources.GetObject("pbCoolSquirtle.Image")));
            this.pbCoolSquirtle.Location = new System.Drawing.Point(248, 26);
            this.pbCoolSquirtle.Name = "pbCoolSquirtle";
            this.pbCoolSquirtle.Size = new System.Drawing.Size(137, 109);
            this.pbCoolSquirtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoolSquirtle.TabIndex = 3;
            this.pbCoolSquirtle.TabStop = false;
            this.pbCoolSquirtle.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Squirtle";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Charmander";
            this.label2.Visible = false;
            // 
            // btnSqirtlePick
            // 
            this.btnSqirtlePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqirtlePick.Location = new System.Drawing.Point(257, 141);
            this.btnSqirtlePick.Name = "btnSqirtlePick";
            this.btnSqirtlePick.Size = new System.Drawing.Size(116, 23);
            this.btnSqirtlePick.TabIndex = 6;
            this.btnSqirtlePick.Text = "Click to choose!";
            this.btnSqirtlePick.UseVisualStyleBackColor = true;
            this.btnSqirtlePick.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(826, 382);
            this.Controls.Add(this.btnSqirtlePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCoolSquirtle);
            this.Controls.Add(this.pbSecondPokeball);
            this.Controls.Add(this.pbFirstPokeball);
            this.Controls.Add(this.btnQuickGame);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstPokeball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondPokeball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoolSquirtle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuickGame;
        private System.Windows.Forms.PictureBox pbFirstPokeball;
        private System.Windows.Forms.PictureBox pbSecondPokeball;
        private System.Windows.Forms.PictureBox pbCoolSquirtle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSqirtlePick;
    }
}

