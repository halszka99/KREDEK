namespace HalszkaCiesielskaZad1
{
    partial class FormEndGame
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
            this.labelEndGame = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.pictureBoxEndBeaver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndBeaver)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEndGame
            // 
            this.labelEndGame.AutoSize = true;
            this.labelEndGame.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndGame.Location = new System.Drawing.Point(84, 68);
            this.labelEndGame.Name = "labelEndGame";
            this.labelEndGame.Size = new System.Drawing.Size(0, 25);
            this.labelEndGame.TabIndex = 0;
            this.labelEndGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(80, 166);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(168, 74);
            this.buttonPlayAgain.TabIndex = 1;
            this.buttonPlayAgain.Text = "Play again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndGame.Location = new System.Drawing.Point(376, 144);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(168, 74);
            this.buttonEndGame.TabIndex = 2;
            this.buttonEndGame.Text = "End game";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // pictureBoxEndBeaver
            // 
            this.pictureBoxEndBeaver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEndBeaver.Image = global::HalszkaCiesielskaZad1.Properties.Resources.beavergood;
            this.pictureBoxEndBeaver.Location = new System.Drawing.Point(136, 166);
            this.pictureBoxEndBeaver.Name = "pictureBoxEndBeaver";
            this.pictureBoxEndBeaver.Size = new System.Drawing.Size(313, 284);
            this.pictureBoxEndBeaver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEndBeaver.TabIndex = 3;
            this.pictureBoxEndBeaver.TabStop = false;
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(620, 453);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.pictureBoxEndBeaver);
            this.Controls.Add(this.labelEndGame);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEndGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE BEAVERS VILLAGE SIMULATOR";
            this.Load += new System.EventHandler(this.FormEndGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndBeaver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEndGame;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.PictureBox pictureBoxEndBeaver;
    }
}