namespace HalszkaCiesielskaZad4
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxFoodName = new System.Windows.Forms.ComboBox();
            this.comboBoxPositions = new System.Windows.Forms.ComboBox();
            this.buttonBuyFood = new System.Windows.Forms.Button();
            this.buttonHire = new System.Windows.Forms.Button();
            this.comboBoxContent = new System.Windows.Forms.ComboBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.comboBoxCage = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimalClass = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.pictureBoxSign = new System.Windows.Forms.PictureBox();
            this.pictureBoxZoo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(579, 405);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(139, 22);
            this.textBoxFirstName.TabIndex = 31;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(579, 433);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(139, 22);
            this.textBoxLastName.TabIndex = 30;
            // 
            // comboBoxFoodName
            // 
            this.comboBoxFoodName.FormattingEnabled = true;
            this.comboBoxFoodName.Location = new System.Drawing.Point(579, 555);
            this.comboBoxFoodName.Name = "comboBoxFoodName";
            this.comboBoxFoodName.Size = new System.Drawing.Size(139, 24);
            this.comboBoxFoodName.TabIndex = 29;
            // 
            // comboBoxPositions
            // 
            this.comboBoxPositions.FormattingEnabled = true;
            this.comboBoxPositions.Location = new System.Drawing.Point(579, 375);
            this.comboBoxPositions.Name = "comboBoxPositions";
            this.comboBoxPositions.Size = new System.Drawing.Size(139, 24);
            this.comboBoxPositions.TabIndex = 28;
            // 
            // buttonBuyFood
            // 
            this.buttonBuyFood.Location = new System.Drawing.Point(579, 498);
            this.buttonBuyFood.Name = "buttonBuyFood";
            this.buttonBuyFood.Size = new System.Drawing.Size(139, 51);
            this.buttonBuyFood.TabIndex = 27;
            this.buttonBuyFood.Text = "Buy food";
            this.buttonBuyFood.UseVisualStyleBackColor = true;
            this.buttonBuyFood.Click += new System.EventHandler(this.buttonBuyFood_Click);
            // 
            // buttonHire
            // 
            this.buttonHire.Location = new System.Drawing.Point(580, 317);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(139, 51);
            this.buttonHire.TabIndex = 26;
            this.buttonHire.Text = "Hire employee";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // comboBoxContent
            // 
            this.comboBoxContent.FormattingEnabled = true;
            this.comboBoxContent.Items.AddRange(new object[] {
            "Animals",
            "Animal classes",
            "Areas",
            "Cages",
            "Employees",
            "Foods",
            "Positions"});
            this.comboBoxContent.Location = new System.Drawing.Point(40, 221);
            this.comboBoxContent.Name = "comboBoxContent";
            this.comboBoxContent.Size = new System.Drawing.Size(501, 24);
            this.comboBoxContent.TabIndex = 25;
            this.comboBoxContent.SelectedIndexChanged += new System.EventHandler(this.comboBoxContent_SelectedIndexChanged);
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(40, 266);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.Size = new System.Drawing.Size(497, 351);
            this.dataGridViewList.TabIndex = 24;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(834, 313);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(141, 55);
            this.buttonUpdate.TabIndex = 38;
            this.buttonUpdate.Text = "Update animal data";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(833, 523);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 55);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Delete animal";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(833, 372);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(141, 55);
            this.buttonAddAnimal.TabIndex = 36;
            this.buttonAddAnimal.Text = "Add new animal";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // comboBoxCage
            // 
            this.comboBoxCage.FormattingEnabled = true;
            this.comboBoxCage.Location = new System.Drawing.Point(833, 494);
            this.comboBoxCage.Name = "comboBoxCage";
            this.comboBoxCage.Size = new System.Drawing.Size(141, 24);
            this.comboBoxCage.TabIndex = 35;
            this.comboBoxCage.Text = "Cage";
            // 
            // comboBoxAnimalClass
            // 
            this.comboBoxAnimalClass.FormattingEnabled = true;
            this.comboBoxAnimalClass.Location = new System.Drawing.Point(833, 464);
            this.comboBoxAnimalClass.Name = "comboBoxAnimalClass";
            this.comboBoxAnimalClass.Size = new System.Drawing.Size(141, 24);
            this.comboBoxAnimalClass.TabIndex = 34;
            this.comboBoxAnimalClass.Text = "Animal class";
            this.comboBoxAnimalClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimalClass_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(833, 433);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(141, 22);
            this.textBoxName.TabIndex = 33;
            this.textBoxName.Text = "Animal name";
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(443, 149);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(0, 28);
            this.labelWelcomeMessage.TabIndex = 40;
            // 
            // pictureBoxSign
            // 
            this.pictureBoxSign.Image = global::HalszkaCiesielskaZad4.Properties.Resources.zooSign;
            this.pictureBoxSign.Location = new System.Drawing.Point(443, 12);
            this.pictureBoxSign.Name = "pictureBoxSign";
            this.pictureBoxSign.Size = new System.Drawing.Size(398, 106);
            this.pictureBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSign.TabIndex = 39;
            this.pictureBoxSign.TabStop = false;
            // 
            // pictureBoxZoo
            // 
            this.pictureBoxZoo.Image = global::HalszkaCiesielskaZad4.Properties.Resources.zoo;
            this.pictureBoxZoo.Location = new System.Drawing.Point(753, 266);
            this.pictureBoxZoo.Name = "pictureBoxZoo";
            this.pictureBoxZoo.Size = new System.Drawing.Size(436, 351);
            this.pictureBoxZoo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxZoo.TabIndex = 41;
            this.pictureBoxZoo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 659);
            this.Controls.Add(this.pictureBoxZoo);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Controls.Add(this.pictureBoxSign);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.comboBoxCage);
            this.Controls.Add(this.comboBoxAnimalClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.comboBoxFoodName);
            this.Controls.Add(this.comboBoxPositions);
            this.Controls.Add(this.buttonBuyFood);
            this.Controls.Add(this.buttonHire);
            this.Controls.Add(this.comboBoxContent);
            this.Controls.Add(this.dataGridViewList);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE ZOO";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxFoodName;
        private System.Windows.Forms.ComboBox comboBoxPositions;
        private System.Windows.Forms.Button buttonBuyFood;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.ComboBox comboBoxContent;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ComboBox comboBoxCage;
        private System.Windows.Forms.ComboBox comboBoxAnimalClass;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.PictureBox pictureBoxSign;
        private System.Windows.Forms.PictureBox pictureBoxZoo;
    }
}

