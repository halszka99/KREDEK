using System;
using System.Data;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    public partial class FromMain : Form
    {
        private readonly AnimalClassesRepository animalClassesRepository;
        private readonly AnimalsRepository animalsRepository;
        private readonly AreasRepository areasRepository;
        private readonly CagesRepository cagesRepository;
        private readonly EmployeesRepository employeesRepository;
        private readonly FoodsRepository foodsRepository;
        private readonly PositionsRepository positionsRepository;

        public FromMain()
        {
            animalClassesRepository = new AnimalClassesRepository();
            animalsRepository = new AnimalsRepository();
            areasRepository = new AreasRepository();
            cagesRepository = new CagesRepository();
            employeesRepository = new EmployeesRepository();
            foodsRepository = new FoodsRepository();
            positionsRepository = new PositionsRepository();

            InitializeComponent();
        }
        private void AnimalServiceVisibility(bool visibility)
        {
            textBoxName.Visible = visibility;
            comboBoxAnimalClass.Visible = visibility;
            comboBoxCage.Visible = visibility;
            buttonDelete.Visible = visibility;
            buttonUpdate.Visible = visibility;
            buttonAddAnimal.Visible = visibility;
            pictureBoxZoo.Visible = !visibility; 
        }
        private void comboBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxContent.SelectedItem.Equals("Animals"))
            { 
                AnimalServiceVisibility(true);
            }
            else 
            {
                AnimalServiceVisibility(false);
            }

            RefreshDataGridView(); 
        }
        private void buttonHire_Click(object sender, EventArgs e)
        {
            string employeeFirstName = textBoxFirstName.Text;
            string employeeLastName = textBoxLastName.Text;
            string employeePositions = comboBoxPositions.Text;

            employeesRepository.CreateEmployee(employeeFirstName, employeeLastName, employeePositions);
            comboBoxContent.SelectedIndex = 4;
            RefreshDataGridView();

        }

        private void buttonBuyFood_Click(object sender, EventArgs e)
        {
            string foodName = comboBoxFoodName.Text;

            foodsRepository.UpdateFoodAmount(foodName);
            comboBoxContent.SelectedIndex = 5;
            RefreshDataGridView();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            AnimalServiceVisibility(false);
            ComboBoxesFill();
            labelMessage.Text = employeesRepository.WelcomeMessage(Program.EmployeeId);
        }

        private void ComboBoxesFill()
        {
            comboBoxPositions.DisplayMember = "Name";
            comboBoxPositions.DataSource = positionsRepository.GetPositionsNames().Tables["Positions"];

            comboBoxFoodName.DisplayMember = "Name";
            comboBoxFoodName.DataSource = foodsRepository.GetFoodsNames().Tables["Foods"];

            comboBoxAnimalClass.DisplayMember = "Name";
            comboBoxAnimalClass.DataSource = animalClassesRepository.GetAnimalClassesNames().Tables["Animal Classes"];

        }

        private void RefreshDataGridView()
        {
            if (comboBoxContent.SelectedItem.Equals("Animal classes"))
            {
                DataTable animalClasses = animalClassesRepository.GetAnimalClasses();
                dataGridViewList.DataSource = animalClasses;
            }
            else if (comboBoxContent.SelectedItem.Equals("Animals"))
            {
                DataTable animals = animalsRepository.GetAnimals(); 
                dataGridViewList.DataSource = animals;
            }
            else if (comboBoxContent.SelectedItem.Equals("Areas"))
            {
                DataTable areas = areasRepository.GetAreas();
                dataGridViewList.DataSource = areas;
            }
            else if (comboBoxContent.SelectedItem.Equals("Cages"))
            {
                DataTable cages = cagesRepository.GetCages(); 
                dataGridViewList.DataSource = cages;
            }
            else if (comboBoxContent.SelectedItem.Equals("Employees"))
            {
                DataTable employees = employeesRepository.GetEmployees(); 
                dataGridViewList.DataSource = employees;
            }
            else if (comboBoxContent.SelectedItem.Equals("Foods"))
            {
                DataTable foods = foodsRepository.GetFoods();
                dataGridViewList.DataSource = foods;
            }
            else if (comboBoxContent.SelectedItem.Equals("Positions"))
            {
                DataTable positions = positionsRepository.GetPositions(); 
                dataGridViewList.DataSource = positions;
            }
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            string animalName = textBoxName.Text;
            string animalClass = comboBoxAnimalClass.Text;
            int cageNumber = int.Parse(comboBoxCage.Text); 

            animalsRepository.CreateAnimal(animalName, animalClass, cageNumber);

            RefreshDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();

            string selectedAnimalName = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
            string selectedAnimalClass = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            int selectedCageNumber = int.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString());

            animalsRepository.DeleteAnimal(selectedAnimalName, selectedAnimalClass, selectedCageNumber);
            RefreshDataGridView();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string newAnimalName = textBoxName.Text;
            string newAnimalClass = comboBoxAnimalClass.Text;
            int newCageNumber = int.Parse(comboBoxCage.Text);

            int rowIndex = dataGridViewList.CurrentCell.RowIndex;

            dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();

            string oldAnimalName = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
            string oldAnimalClass = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            int oldCageNumber = int.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString());

            animalsRepository.UpdateAnimal(newAnimalName, newAnimalClass, newCageNumber,oldAnimalName, oldAnimalClass, oldCageNumber);
            RefreshDataGridView();

        }

        private void comboBoxAnimalClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCage.ValueMember = "Id";
            comboBoxCage.DataSource = cagesRepository.GetCagesNames(comboBoxAnimalClass.Text).Tables["Cages"];
        }
    }
}
