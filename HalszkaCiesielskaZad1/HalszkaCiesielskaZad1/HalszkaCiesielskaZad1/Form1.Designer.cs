namespace HalszkaCiesielskaZad1
{
    partial class FormStartWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.textBoxYourName = new System.Windows.Forms.TextBox();
            this.labelYourName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.Location = new System.Drawing.Point(209, 125);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(224, 67);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // textBoxYourName
            // 
            this.textBoxYourName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYourName.Location = new System.Drawing.Point(209, 81);
            this.textBoxYourName.Name = "textBoxYourName";
            this.textBoxYourName.Size = new System.Drawing.Size(224, 25);
            this.textBoxYourName.TabIndex = 1;
            this.textBoxYourName.Text = "Player";
            this.textBoxYourName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.BackColor = System.Drawing.Color.Transparent;
            this.labelYourName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourName.Location = new System.Drawing.Point(254, 60);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(156, 21);
            this.labelYourName.TabIndex = 2;
            this.labelYourName.Text = "Enter your name: ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(113, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(548, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "THE BEAVERS VILLAGE SIMULATOR";
            // 
            // FormStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HalszkaCiesielskaZad1.Properties.Resources.beaverBackground;
            this.ClientSize = new System.Drawing.Size(623, 603);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelYourName);
            this.Controls.Add(this.textBoxYourName);
            this.Controls.Add(this.buttonStartGame);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormStartWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE BEAVERS VILLAGE SIMULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TextBox textBoxYourName;
        private System.Windows.Forms.Label labelYourName;
        private System.Windows.Forms.Label labelTitle;
    }
}

