
namespace HalszkaCiesielskaWyk
{
    partial class FormMain
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
            this.comboBoxCreate = new System.Windows.Forms.ComboBox();
            this.buttonCreateFromCheckBox = new System.Windows.Forms.Button();
            this.checkedListBoxResources = new System.Windows.Forms.CheckedListBox();
            this.buttonCreateFromComboBox = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelCheckBoxInfo = new System.Windows.Forms.Label();
            this.labelComboBoxInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCreate
            // 
            this.comboBoxCreate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCreate.FormattingEnabled = true;
            this.comboBoxCreate.Items.AddRange(new object[] {
            "Dust",
            "Energy",
            "Lava",
            "Mud",
            "Rain",
            "Steam"});
            this.comboBoxCreate.Location = new System.Drawing.Point(9, 383);
            this.comboBoxCreate.Name = "comboBoxCreate";
            this.comboBoxCreate.Size = new System.Drawing.Size(196, 35);
            this.comboBoxCreate.TabIndex = 5;
            // 
            // buttonCreateFromCheckBox
            // 
            this.buttonCreateFromCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateFromCheckBox.Location = new System.Drawing.Point(14, 233);
            this.buttonCreateFromCheckBox.Name = "buttonCreateFromCheckBox";
            this.buttonCreateFromCheckBox.Size = new System.Drawing.Size(196, 46);
            this.buttonCreateFromCheckBox.TabIndex = 4;
            this.buttonCreateFromCheckBox.Text = "CREATE";
            this.buttonCreateFromCheckBox.UseVisualStyleBackColor = true;
            this.buttonCreateFromCheckBox.Click += new System.EventHandler(this.buttonCreateFromCheckBox_Click);
            // 
            // checkedListBoxResources
            // 
            this.checkedListBoxResources.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxResources.FormattingEnabled = true;
            this.checkedListBoxResources.Items.AddRange(new object[] {
            "Air",
            "Earth",
            "Fire",
            "Water"});
            this.checkedListBoxResources.Location = new System.Drawing.Point(14, 55);
            this.checkedListBoxResources.Name = "checkedListBoxResources";
            this.checkedListBoxResources.Size = new System.Drawing.Size(196, 200);
            this.checkedListBoxResources.TabIndex = 3;
            // 
            // buttonCreateFromComboBox
            // 
            this.buttonCreateFromComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateFromComboBox.Location = new System.Drawing.Point(9, 433);
            this.buttonCreateFromComboBox.Name = "buttonCreateFromComboBox";
            this.buttonCreateFromComboBox.Size = new System.Drawing.Size(196, 46);
            this.buttonCreateFromComboBox.TabIndex = 6;
            this.buttonCreateFromComboBox.Text = "CREATE";
            this.buttonCreateFromComboBox.UseVisualStyleBackColor = true;
            this.buttonCreateFromComboBox.Click += new System.EventHandler(this.buttonCreateFromComboBox_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(243, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 172);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "air + earth = dust\nfire + air = energy\nfire + earth = lava\nwater + earth = mud\nwa" +
    "ter + air = rain\nwater + fire = steam";
            // 
            // labelCheckBoxInfo
            // 
            this.labelCheckBoxInfo.AutoSize = true;
            this.labelCheckBoxInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCheckBoxInfo.Location = new System.Drawing.Point(7, 9);
            this.labelCheckBoxInfo.Name = "labelCheckBoxInfo";
            this.labelCheckBoxInfo.Size = new System.Drawing.Size(405, 27);
            this.labelCheckBoxInfo.TabIndex = 10;
            this.labelCheckBoxInfo.Text = "Choose two resources to create new item";
            // 
            // labelComboBoxInfo
            // 
            this.labelComboBoxInfo.AutoSize = true;
            this.labelComboBoxInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComboBoxInfo.Location = new System.Drawing.Point(9, 334);
            this.labelComboBoxInfo.Name = "labelComboBoxInfo";
            this.labelComboBoxInfo.Size = new System.Drawing.Size(221, 27);
            this.labelComboBoxInfo.TabIndex = 11;
            this.labelComboBoxInfo.Text = "Choose item to create";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 528);
            this.Controls.Add(this.labelComboBoxInfo);
            this.Controls.Add(this.labelCheckBoxInfo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCreateFromComboBox);
            this.Controls.Add(this.comboBoxCreate);
            this.Controls.Add(this.buttonCreateFromCheckBox);
            this.Controls.Add(this.checkedListBoxResources);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LITTLE ALCHEMY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCreate;
        private System.Windows.Forms.Button buttonCreateFromCheckBox;
        private System.Windows.Forms.CheckedListBox checkedListBoxResources;
        private System.Windows.Forms.Button buttonCreateFromComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelCheckBoxInfo;
        private System.Windows.Forms.Label labelComboBoxInfo;
    }
}

