
namespace HalszkaCiesielskaWyk
{
    partial class FormCreated
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
            this.labelCreated = new System.Windows.Forms.Label();
            this.pictureBoxCreated = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreated)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCreated.Location = new System.Drawing.Point(60, 40);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(0, 46);
            this.labelCreated.TabIndex = 9;
            // 
            // pictureBoxCreated
            // 
            this.pictureBoxCreated.Location = new System.Drawing.Point(67, 103);
            this.pictureBoxCreated.Name = "pictureBoxCreated";
            this.pictureBoxCreated.Size = new System.Drawing.Size(239, 221);
            this.pictureBoxCreated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCreated.TabIndex = 10;
            this.pictureBoxCreated.TabStop = false;
            // 
            // FormCreated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 377);
            this.Controls.Add(this.pictureBoxCreated);
            this.Controls.Add(this.labelCreated);
            this.Name = "FormCreated";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LITTLE ALCHEMY - Created item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelCreated;
        public System.Windows.Forms.PictureBox pictureBoxCreated;
    }
}