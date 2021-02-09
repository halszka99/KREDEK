using System;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCats = new System.Windows.Forms.DataGridView();
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.dataGridViewBirds = new System.Windows.Forms.DataGridView();
            this.buttonCreateFarm = new System.Windows.Forms.Button();
            this.buttonCreateDog = new System.Windows.Forms.Button();
            this.buttonCreateCat = new System.Windows.Forms.Button();
            this.buttonCreateBird = new System.Windows.Forms.Button();
            this.buttonFindBird = new System.Windows.Forms.Button();
            this.buttonFindCat = new System.Windows.Forms.Button();
            this.buttonFindDog = new System.Windows.Forms.Button();
            this.buttonEditBird = new System.Windows.Forms.Button();
            this.buttonEditCat = new System.Windows.Forms.Button();
            this.buttonEditDog = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxFoodLevel = new System.Windows.Forms.TextBox();
            this.textBoxMoodLevel = new System.Windows.Forms.TextBox();
            this.buttonFeedBird = new System.Windows.Forms.Button();
            this.buttonFeedCat = new System.Windows.Forms.Button();
            this.buttonFeedDog = new System.Windows.Forms.Button();
            this.buttonDeleteDog = new System.Windows.Forms.Button();
            this.buttonDeleteCat = new System.Windows.Forms.Button();
            this.buttonDeleteBird = new System.Windows.Forms.Button();
            this.buttonPlayWithBird = new System.Windows.Forms.Button();
            this.buttonPlayWithCat = new System.Windows.Forms.Button();
            this.buttonPlayWithDog = new System.Windows.Forms.Button();
            this.textBoxDogFood = new System.Windows.Forms.TextBox();
            this.textBoxCatFood = new System.Windows.Forms.TextBox();
            this.textBoxGrain = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelFoodLevel = new System.Windows.Forms.Label();
            this.labelMoodLevel = new System.Windows.Forms.Label();
            this.labelDogFood = new System.Windows.Forms.Label();
            this.labelCatFood = new System.Windows.Forms.Label();
            this.labelGrain = new System.Windows.Forms.Label();
            this.checkBoxFlying = new System.Windows.Forms.CheckBox();
            this.timerDuration = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirds)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCats
            // 
            this.dataGridViewCats.AllowUserToAddRows = false;
            this.dataGridViewCats.AllowUserToDeleteRows = false;
            this.dataGridViewCats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCats.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewCats.Name = "dataGridViewCats";
            this.dataGridViewCats.ReadOnly = true;
            this.dataGridViewCats.RowHeadersWidth = 51;
            this.dataGridViewCats.RowTemplate.Height = 24;
            this.dataGridViewCats.Size = new System.Drawing.Size(540, 196);
            this.dataGridViewCats.TabIndex = 0;
            this.dataGridViewCats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCats_CellClick);
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.AllowUserToResizeColumns = false;
            this.dataGridViewDogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDogs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.ReadOnly = true;
            this.dataGridViewDogs.RowHeadersWidth = 51;
            this.dataGridViewDogs.RowTemplate.Height = 24;
            this.dataGridViewDogs.Size = new System.Drawing.Size(540, 196);
            this.dataGridViewDogs.TabIndex = 1;
            this.dataGridViewDogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDogs_CellClick);
            // 
            // dataGridViewBirds
            // 
            this.dataGridViewBirds.AllowUserToAddRows = false;
            this.dataGridViewBirds.AllowUserToDeleteRows = false;
            this.dataGridViewBirds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirds.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBirds.Location = new System.Drawing.Point(12, 416);
            this.dataGridViewBirds.Name = "dataGridViewBirds";
            this.dataGridViewBirds.ReadOnly = true;
            this.dataGridViewBirds.RowHeadersWidth = 51;
            this.dataGridViewBirds.RowTemplate.Height = 24;
            this.dataGridViewBirds.Size = new System.Drawing.Size(540, 196);
            this.dataGridViewBirds.TabIndex = 2;
            this.dataGridViewBirds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBirds_CellClick);
            // 
            // buttonCreateFarm
            // 
            this.buttonCreateFarm.Location = new System.Drawing.Point(1048, 31);
            this.buttonCreateFarm.Name = "buttonCreateFarm";
            this.buttonCreateFarm.Size = new System.Drawing.Size(176, 59);
            this.buttonCreateFarm.TabIndex = 3;
            this.buttonCreateFarm.Text = "Create farm";
            this.buttonCreateFarm.UseVisualStyleBackColor = true;
            this.buttonCreateFarm.Click += new System.EventHandler(this.buttonCreateFarm_Click);
            // 
            // buttonCreateDog
            // 
            this.buttonCreateDog.Location = new System.Drawing.Point(740, 12);
            this.buttonCreateDog.Name = "buttonCreateDog";
            this.buttonCreateDog.Size = new System.Drawing.Size(176, 59);
            this.buttonCreateDog.TabIndex = 4;
            this.buttonCreateDog.Text = "Create dog";
            this.buttonCreateDog.UseVisualStyleBackColor = true;
            this.buttonCreateDog.Click += new System.EventHandler(this.buttonCreateDog_Click);
            // 
            // buttonCreateCat
            // 
            this.buttonCreateCat.Location = new System.Drawing.Point(740, 214);
            this.buttonCreateCat.Name = "buttonCreateCat";
            this.buttonCreateCat.Size = new System.Drawing.Size(176, 59);
            this.buttonCreateCat.TabIndex = 5;
            this.buttonCreateCat.Text = "Create cat";
            this.buttonCreateCat.UseVisualStyleBackColor = true;
            this.buttonCreateCat.Click += new System.EventHandler(this.buttonCreateCat_Click);
            // 
            // buttonCreateBird
            // 
            this.buttonCreateBird.Location = new System.Drawing.Point(740, 416);
            this.buttonCreateBird.Name = "buttonCreateBird";
            this.buttonCreateBird.Size = new System.Drawing.Size(176, 59);
            this.buttonCreateBird.TabIndex = 6;
            this.buttonCreateBird.Text = "Create bird";
            this.buttonCreateBird.UseVisualStyleBackColor = true;
            this.buttonCreateBird.Click += new System.EventHandler(this.buttonCreateBird_Click);
            // 
            // buttonFindBird
            // 
            this.buttonFindBird.Location = new System.Drawing.Point(558, 483);
            this.buttonFindBird.Name = "buttonFindBird";
            this.buttonFindBird.Size = new System.Drawing.Size(176, 59);
            this.buttonFindBird.TabIndex = 9;
            this.buttonFindBird.Text = "Find bird";
            this.buttonFindBird.UseVisualStyleBackColor = true;
            this.buttonFindBird.Click += new System.EventHandler(this.buttonFindBird_Click);
            // 
            // buttonFindCat
            // 
            this.buttonFindCat.Location = new System.Drawing.Point(558, 281);
            this.buttonFindCat.Name = "buttonFindCat";
            this.buttonFindCat.Size = new System.Drawing.Size(176, 59);
            this.buttonFindCat.TabIndex = 8;
            this.buttonFindCat.Text = "Find cat";
            this.buttonFindCat.UseVisualStyleBackColor = true;
            this.buttonFindCat.Click += new System.EventHandler(this.buttonFindCat_Click);
            // 
            // buttonFindDog
            // 
            this.buttonFindDog.Location = new System.Drawing.Point(558, 77);
            this.buttonFindDog.Name = "buttonFindDog";
            this.buttonFindDog.Size = new System.Drawing.Size(176, 59);
            this.buttonFindDog.TabIndex = 7;
            this.buttonFindDog.Text = "Find dog";
            this.buttonFindDog.UseVisualStyleBackColor = true;
            this.buttonFindDog.Click += new System.EventHandler(this.buttonFindDog_Click);
            // 
            // buttonEditBird
            // 
            this.buttonEditBird.Location = new System.Drawing.Point(558, 548);
            this.buttonEditBird.Name = "buttonEditBird";
            this.buttonEditBird.Size = new System.Drawing.Size(176, 59);
            this.buttonEditBird.TabIndex = 12;
            this.buttonEditBird.Text = "Edit bird";
            this.buttonEditBird.UseVisualStyleBackColor = true;
            this.buttonEditBird.Click += new System.EventHandler(this.buttonEditBird_Click);
            // 
            // buttonEditCat
            // 
            this.buttonEditCat.Location = new System.Drawing.Point(558, 348);
            this.buttonEditCat.Name = "buttonEditCat";
            this.buttonEditCat.Size = new System.Drawing.Size(176, 59);
            this.buttonEditCat.TabIndex = 11;
            this.buttonEditCat.Text = "Edit cat";
            this.buttonEditCat.UseVisualStyleBackColor = true;
            this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
            // 
            // buttonEditDog
            // 
            this.buttonEditDog.Location = new System.Drawing.Point(558, 142);
            this.buttonEditDog.Name = "buttonEditDog";
            this.buttonEditDog.Size = new System.Drawing.Size(176, 59);
            this.buttonEditDog.TabIndex = 10;
            this.buttonEditDog.Text = "Edit dog";
            this.buttonEditDog.UseVisualStyleBackColor = true;
            this.buttonEditDog.Click += new System.EventHandler(this.buttonEditDog_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1048, 142);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 22);
            this.textBoxName.TabIndex = 13;
            this.textBoxName.Text = "animal name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(1048, 193);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(176, 22);
            this.textBoxWeight.TabIndex = 14;
            this.textBoxWeight.Text = "0";
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFoodLevel
            // 
            this.textBoxFoodLevel.Location = new System.Drawing.Point(1048, 244);
            this.textBoxFoodLevel.Name = "textBoxFoodLevel";
            this.textBoxFoodLevel.ReadOnly = true;
            this.textBoxFoodLevel.Size = new System.Drawing.Size(176, 22);
            this.textBoxFoodLevel.TabIndex = 15;
            this.textBoxFoodLevel.Text = "0";
            this.textBoxFoodLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMoodLevel
            // 
            this.textBoxMoodLevel.Location = new System.Drawing.Point(1048, 295);
            this.textBoxMoodLevel.Name = "textBoxMoodLevel";
            this.textBoxMoodLevel.ReadOnly = true;
            this.textBoxMoodLevel.Size = new System.Drawing.Size(176, 22);
            this.textBoxMoodLevel.TabIndex = 16;
            this.textBoxMoodLevel.Text = "0";
            this.textBoxMoodLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFeedBird
            // 
            this.buttonFeedBird.Location = new System.Drawing.Point(740, 483);
            this.buttonFeedBird.Name = "buttonFeedBird";
            this.buttonFeedBird.Size = new System.Drawing.Size(176, 59);
            this.buttonFeedBird.TabIndex = 19;
            this.buttonFeedBird.Text = "Feed bird";
            this.buttonFeedBird.UseVisualStyleBackColor = true;
            this.buttonFeedBird.Click += new System.EventHandler(this.buttonFeedBird_Click);
            // 
            // buttonFeedCat
            // 
            this.buttonFeedCat.Location = new System.Drawing.Point(740, 281);
            this.buttonFeedCat.Name = "buttonFeedCat";
            this.buttonFeedCat.Size = new System.Drawing.Size(176, 59);
            this.buttonFeedCat.TabIndex = 18;
            this.buttonFeedCat.Text = "Feed cat";
            this.buttonFeedCat.UseVisualStyleBackColor = true;
            this.buttonFeedCat.Click += new System.EventHandler(this.buttonFeedCat_Click);
            // 
            // buttonFeedDog
            // 
            this.buttonFeedDog.Location = new System.Drawing.Point(740, 77);
            this.buttonFeedDog.Name = "buttonFeedDog";
            this.buttonFeedDog.Size = new System.Drawing.Size(176, 59);
            this.buttonFeedDog.TabIndex = 17;
            this.buttonFeedDog.Text = "Feed dog";
            this.buttonFeedDog.UseVisualStyleBackColor = true;
            this.buttonFeedDog.Click += new System.EventHandler(this.buttonFeedDog_Click);
            // 
            // buttonDeleteDog
            // 
            this.buttonDeleteDog.Location = new System.Drawing.Point(558, 12);
            this.buttonDeleteDog.Name = "buttonDeleteDog";
            this.buttonDeleteDog.Size = new System.Drawing.Size(176, 59);
            this.buttonDeleteDog.TabIndex = 20;
            this.buttonDeleteDog.Text = "Delete dog";
            this.buttonDeleteDog.UseVisualStyleBackColor = true;
            this.buttonDeleteDog.Click += new System.EventHandler(this.buttonDeleteDog_Click);
            // 
            // buttonDeleteCat
            // 
            this.buttonDeleteCat.Location = new System.Drawing.Point(558, 214);
            this.buttonDeleteCat.Name = "buttonDeleteCat";
            this.buttonDeleteCat.Size = new System.Drawing.Size(176, 59);
            this.buttonDeleteCat.TabIndex = 21;
            this.buttonDeleteCat.Text = "Delete cat";
            this.buttonDeleteCat.UseVisualStyleBackColor = true;
            this.buttonDeleteCat.Click += new System.EventHandler(this.buttonDeleteCat_Click);
            // 
            // buttonDeleteBird
            // 
            this.buttonDeleteBird.Location = new System.Drawing.Point(558, 416);
            this.buttonDeleteBird.Name = "buttonDeleteBird";
            this.buttonDeleteBird.Size = new System.Drawing.Size(176, 59);
            this.buttonDeleteBird.TabIndex = 22;
            this.buttonDeleteBird.Text = "Delete bird";
            this.buttonDeleteBird.UseVisualStyleBackColor = true;
            this.buttonDeleteBird.Click += new System.EventHandler(this.buttonDeleteBird_Click);
            // 
            // buttonPlayWithBird
            // 
            this.buttonPlayWithBird.Location = new System.Drawing.Point(740, 548);
            this.buttonPlayWithBird.Name = "buttonPlayWithBird";
            this.buttonPlayWithBird.Size = new System.Drawing.Size(176, 59);
            this.buttonPlayWithBird.TabIndex = 25;
            this.buttonPlayWithBird.Text = "Play with bird";
            this.buttonPlayWithBird.UseVisualStyleBackColor = true;
            this.buttonPlayWithBird.Click += new System.EventHandler(this.buttonPlayWithBird_Click);
            // 
            // buttonPlayWithCat
            // 
            this.buttonPlayWithCat.Location = new System.Drawing.Point(740, 348);
            this.buttonPlayWithCat.Name = "buttonPlayWithCat";
            this.buttonPlayWithCat.Size = new System.Drawing.Size(176, 59);
            this.buttonPlayWithCat.TabIndex = 24;
            this.buttonPlayWithCat.Text = "Play with cat";
            this.buttonPlayWithCat.UseVisualStyleBackColor = true;
            this.buttonPlayWithCat.Click += new System.EventHandler(this.buttonPlayWithCat_Click);
            // 
            // buttonPlayWithDog
            // 
            this.buttonPlayWithDog.Location = new System.Drawing.Point(740, 142);
            this.buttonPlayWithDog.Name = "buttonPlayWithDog";
            this.buttonPlayWithDog.Size = new System.Drawing.Size(176, 59);
            this.buttonPlayWithDog.TabIndex = 23;
            this.buttonPlayWithDog.Text = "Play with dog";
            this.buttonPlayWithDog.UseVisualStyleBackColor = true;
            this.buttonPlayWithDog.Click += new System.EventHandler(this.buttonPlayWithDog_Click);
            // 
            // textBoxDogFood
            // 
            this.textBoxDogFood.Location = new System.Drawing.Point(1048, 407);
            this.textBoxDogFood.Name = "textBoxDogFood";
            this.textBoxDogFood.ReadOnly = true;
            this.textBoxDogFood.Size = new System.Drawing.Size(176, 22);
            this.textBoxDogFood.TabIndex = 26;
            // 
            // textBoxCatFood
            // 
            this.textBoxCatFood.Location = new System.Drawing.Point(1048, 458);
            this.textBoxCatFood.Name = "textBoxCatFood";
            this.textBoxCatFood.ReadOnly = true;
            this.textBoxCatFood.Size = new System.Drawing.Size(176, 22);
            this.textBoxCatFood.TabIndex = 27;
            // 
            // textBoxGrain
            // 
            this.textBoxGrain.Location = new System.Drawing.Point(1048, 509);
            this.textBoxGrain.Name = "textBoxGrain";
            this.textBoxGrain.ReadOnly = true;
            this.textBoxGrain.Size = new System.Drawing.Size(176, 22);
            this.textBoxGrain.TabIndex = 28;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(1090, 122);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 17);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "animal name:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(1110, 173);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(52, 17);
            this.labelWeight.TabIndex = 30;
            this.labelWeight.Text = "weight:";
            // 
            // labelFoodLevel
            // 
            this.labelFoodLevel.AutoSize = true;
            this.labelFoodLevel.Location = new System.Drawing.Point(1089, 224);
            this.labelFoodLevel.Name = "labelFoodLevel";
            this.labelFoodLevel.Size = new System.Drawing.Size(99, 17);
            this.labelFoodLevel.TabIndex = 31;
            this.labelFoodLevel.Text = "food level (%):";
            // 
            // labelMoodLevel
            // 
            this.labelMoodLevel.AutoSize = true;
            this.labelMoodLevel.Location = new System.Drawing.Point(1085, 275);
            this.labelMoodLevel.Name = "labelMoodLevel";
            this.labelMoodLevel.Size = new System.Drawing.Size(106, 17);
            this.labelMoodLevel.TabIndex = 32;
            this.labelMoodLevel.Text = "mood level (%):";
            // 
            // labelDogFood
            // 
            this.labelDogFood.AutoSize = true;
            this.labelDogFood.Location = new System.Drawing.Point(1102, 388);
            this.labelDogFood.Name = "labelDogFood";
            this.labelDogFood.Size = new System.Drawing.Size(68, 17);
            this.labelDogFood.TabIndex = 33;
            this.labelDogFood.Text = "dog food:";
            // 
            // labelCatFood
            // 
            this.labelCatFood.AutoSize = true;
            this.labelCatFood.Location = new System.Drawing.Point(1105, 438);
            this.labelCatFood.Name = "labelCatFood";
            this.labelCatFood.Size = new System.Drawing.Size(63, 17);
            this.labelCatFood.TabIndex = 34;
            this.labelCatFood.Text = "cat food:";
            // 
            // labelGrain
            // 
            this.labelGrain.AutoSize = true;
            this.labelGrain.Location = new System.Drawing.Point(1114, 489);
            this.labelGrain.Name = "labelGrain";
            this.labelGrain.Size = new System.Drawing.Size(44, 17);
            this.labelGrain.TabIndex = 35;
            this.labelGrain.Text = "grain:";
            // 
            // checkBoxFlying
            // 
            this.checkBoxFlying.AutoSize = true;
            this.checkBoxFlying.Location = new System.Drawing.Point(922, 436);
            this.checkBoxFlying.Name = "checkBoxFlying";
            this.checkBoxFlying.Size = new System.Drawing.Size(91, 21);
            this.checkBoxFlying.TabIndex = 36;
            this.checkBoxFlying.Text = "flying bird";
            this.checkBoxFlying.UseVisualStyleBackColor = true;
            // 
            // timerDuration
            // 
            this.timerDuration.Tick += new System.EventHandler(this.timerDuration_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 728);
            this.Controls.Add(this.checkBoxFlying);
            this.Controls.Add(this.labelGrain);
            this.Controls.Add(this.labelCatFood);
            this.Controls.Add(this.labelDogFood);
            this.Controls.Add(this.labelMoodLevel);
            this.Controls.Add(this.labelFoodLevel);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxGrain);
            this.Controls.Add(this.textBoxCatFood);
            this.Controls.Add(this.textBoxDogFood);
            this.Controls.Add(this.buttonPlayWithBird);
            this.Controls.Add(this.buttonPlayWithCat);
            this.Controls.Add(this.buttonPlayWithDog);
            this.Controls.Add(this.buttonDeleteBird);
            this.Controls.Add(this.buttonDeleteCat);
            this.Controls.Add(this.buttonDeleteDog);
            this.Controls.Add(this.buttonFeedBird);
            this.Controls.Add(this.buttonFeedCat);
            this.Controls.Add(this.buttonFeedDog);
            this.Controls.Add(this.textBoxMoodLevel);
            this.Controls.Add(this.textBoxFoodLevel);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEditBird);
            this.Controls.Add(this.buttonEditCat);
            this.Controls.Add(this.buttonEditDog);
            this.Controls.Add(this.buttonFindBird);
            this.Controls.Add(this.buttonFindCat);
            this.Controls.Add(this.buttonFindDog);
            this.Controls.Add(this.buttonCreateBird);
            this.Controls.Add(this.buttonCreateCat);
            this.Controls.Add(this.buttonCreateDog);
            this.Controls.Add(this.buttonCreateFarm);
            this.Controls.Add(this.dataGridViewBirds);
            this.Controls.Add(this.dataGridViewDogs);
            this.Controls.Add(this.dataGridViewCats);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE FARM";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCats;
        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.DataGridView dataGridViewBirds;
        private System.Windows.Forms.Button buttonCreateFarm;
        private System.Windows.Forms.Button buttonCreateDog;
        private System.Windows.Forms.Button buttonCreateCat;
        private System.Windows.Forms.Button buttonCreateBird;
        private System.Windows.Forms.Button buttonEditBird;
        private System.Windows.Forms.Button buttonEditCat;
        private System.Windows.Forms.Button buttonEditDog;
        private System.Windows.Forms.Button buttonFindBird;
        private System.Windows.Forms.Button buttonFindCat;
        private System.Windows.Forms.Button buttonFindDog;
        private System.Windows.Forms.Button buttonFeedBird;
        private System.Windows.Forms.Button buttonFeedCat;
        private System.Windows.Forms.Button buttonFeedDog;
        private System.Windows.Forms.Button buttonDeleteDog;
        private System.Windows.Forms.Button buttonDeleteBird;
        private System.Windows.Forms.Button buttonDeleteCat;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonPlayWithBird;
        private System.Windows.Forms.Button buttonPlayWithCat;
        private System.Windows.Forms.Button buttonPlayWithDog;
        private System.Windows.Forms.Label labelGrain;
        private System.Windows.Forms.Label labelCatFood;
        private System.Windows.Forms.Label labelDogFood;
        private System.Windows.Forms.Label labelMoodLevel;
        private System.Windows.Forms.Label labelFoodLevel;
        private System.Windows.Forms.CheckBox checkBoxFlying;
        private System.Windows.Forms.Timer timerDuration;
        private System.Windows.Forms.TextBox textBoxGrain;
        private System.Windows.Forms.TextBox textBoxCatFood;
        private System.Windows.Forms.TextBox textBoxDogFood;
        private System.Windows.Forms.TextBox textBoxMoodLevel;
        private System.Windows.Forms.TextBox textBoxFoodLevel;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

