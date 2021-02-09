namespace HalszkaCiesielskaZad2
{
    partial class FormEnd
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
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.labelEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.Location = new System.Drawing.Point(12, 287);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(196, 77);
            this.buttonPlayAgain.TabIndex = 0;
            this.buttonPlayAgain.Text = "Play again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(245, 287);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(196, 77);
            this.buttonEnd.TabIndex = 1;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelEnd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(118, 9);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(232, 42);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "Your game is over! \r\nDo you want to play again?";
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HalszkaCiesielskaZad2.Properties.Resources.farm;
            this.ClientSize = new System.Drawing.Size(466, 389);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonPlayAgain);
            this.Name = "FormEnd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE FARM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label labelEnd;
    }
}