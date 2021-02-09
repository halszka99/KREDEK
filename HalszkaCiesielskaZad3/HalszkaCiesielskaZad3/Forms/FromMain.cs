using System;
using System.Data;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad3
{
    /// <summary>
    /// Main form class.
    /// </summary>
    public partial class FromMain : Form
    {
        /// <summary>
        /// Declaration of class to process data connected with AnimalClasses table. 
        /// </summary>
        private readonly AnimalClassesRepository animalClassesRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Animals table. 
        /// </summary>
        private readonly AnimalsRepository animalsRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Areas table. 
        /// </summary>
        private readonly AreasRepository areasRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Cages table. 
        /// </summary>
        private readonly CagesRepository cagesRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Employees table. 
        /// </summary>
        private readonly EmployeesRepository employeesRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Foods table. 
        /// </summary>
        private readonly FoodsRepository foodsRepository;
        /// <summary>
        ///  Declaration of class to process data connected with Positions table. 
        /// </summary>
        private readonly PositionsRepository positionsRepository;
        /// <summary>
        /// FormMain constructor.
        /// </summary>
        public FromMain()
        {
            // initializing repositories
            animalClassesRepository = new AnimalClassesRepository();
            animalsRepository = new AnimalsRepository();
            areasRepository = new AreasRepository();
            cagesRepository = new CagesRepository();
            employeesRepository = new EmployeesRepository();
            foodsRepository = new FoodsRepository();
            positionsRepository = new PositionsRepository();
            // initializing component
            InitializeComponent();
        }
        /// <summary>
        /// Setting visibility of buttons, text boxes, combo boxes and picture.  
        /// </summary>
        /// <param name="visibility"></param>
        private void AnimalServiceVisibility(bool visibility)
        {
            //setting visibility of buttons, text boxes, combo boxes and picture depending on variable visibility
            textBoxName.Visible = visibility;
            comboBoxAnimalClass.Visible = visibility;
            comboBoxCage.Visible = visibility;
            buttonDelete.Visible = visibility;
            buttonUpdate.Visible = visibility;
            buttonAddAnimal.Visible = visibility;
            pictureBoxZoo.Visible = !visibility; 
        }
        /// <summary>
        /// Method to set visibility of buttons, text boxes, combo boxes and picture depending on the comboBoxContent content. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // checking if comboBoxContent content is "Animals"
            if (comboBoxContent.SelectedItem.Equals("Animals"))
            {
                // showing  buttons, text boxes and combo boxes conntected with animals.
                AnimalServiceVisibility(true);
            }
            else 
            {
                // hiding  buttons, text boxes and combo boxes conntected with animals.
                AnimalServiceVisibility(false);
            }
            // refreshing dataGridViewList depending on the comboBoxContent content
            RefreshDataGridView(); 
        }
        /// <summary>
        /// Method called after clicking buttonHire. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHire_Click(object sender, EventArgs e)
        {
            // extracting data from text boxes and combo boxes
            string employeeFirstName = textBoxFirstName.Text;
            string employeeLastName = textBoxLastName.Text;
            string employeePositions = comboBoxPositions.Text;
            // adding new employee to database
            employeesRepository.CreateEmployee(employeeFirstName, employeeLastName, employeePositions);
            // setting comboBocContent to "Employees"
            comboBoxContent.SelectedIndex = 4;
            // refreshing content of dataGridViewList
            RefreshDataGridView();
        }
        /// <summary>
        ///  Method called after clicking buttonBuyFood. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFood_Click(object sender, EventArgs e)
        {
            // extracting name of food to buy from comboBox
            string foodName = comboBoxFoodName.Text;
            // updating amount of food in database
            foodsRepository.UpdateFoodAmount(foodName);
            // setting comboBocContent to "Foods"
            comboBoxContent.SelectedIndex = 5;
            // refreshing content of dataGridViewList
            RefreshDataGridView();
        }
        /// <summary>
        ///  Loading formMain. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FromMain_Load(object sender, EventArgs e)
        {
            // setting visibility of buttons, combo boxes and text boxes connected with animals to false
            AnimalServiceVisibility(false);
            // setting content of comboBoxes 
            ComboBoxesFill();
            // setting message depending on logged employee id
            labelMessage.Text = employeesRepository.WelcomeMessage(Program.EmployeeId);
        }
        /// <summary>
        /// Filling comboBoxes with data from database
        /// </summary>
        private void ComboBoxesFill()
        {
            // setting comboBoxPositions items to positions names
            comboBoxPositions.DisplayMember = "Name";
            // setting comboBoxPositions data source to set of position names
            comboBoxPositions.DataSource = positionsRepository.GetPositionsNames().Tables["Positions"];
            // setting comboBoxFoodName items to foods names
            comboBoxFoodName.DisplayMember = "Name";
            // setting comboBoxFoodName data source to set of foods names
            comboBoxFoodName.DataSource = foodsRepository.GetFoodsNames().Tables["Foods"];
            // setting comboBoxAnimalClass items to animal classes names
            comboBoxAnimalClass.DisplayMember = "Name";
            // setting comboBoxAnimalClass data source to set of animal classes names
            comboBoxAnimalClass.DataSource = animalClassesRepository.GetAnimalClassesNames().Tables["Animal Classes"];
        }
        /// <summary>
        /// Refreshing dataGridViewList content depending on the comboBoxContent content.
        /// </summary>
        private void RefreshDataGridView()
        {
            // checking what is a content of comboBoxContent 
            // and setting the content of dataGridView depending on it
            // by getting all content from the relevant table in database
            if (comboBoxContent.SelectedItem.Equals("Animal classes"))
            {
                DataTable animalClasses = animalClassesRepository.GetAnimalClasses();
                dataGridViewList.DataSource = animalClasses;
            }
            else if (comboBoxContent.SelectedItem.Equals("Animals"))
            {
                DataTable animals = animalsRepository.GetAnimals(); 
                dataGridViewList.DataSource = animals;
                dataGridViewList.Columns[4].Visible = false;
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
        /// <summary>
        ///  Method called after clicking buttonAddAnimal. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            // extracting data about added animal from text boxes and combo boxes
            string animalName = textBoxName.Text;
            string animalClass = comboBoxAnimalClass.Text;
            int cageNumber = int.Parse(comboBoxCage.Text); 
            // adding animal to database
            animalsRepository.CreateAnimal(animalName, animalClass, cageNumber);
            // refreshing dataGridView
            RefreshDataGridView();
        }
        /// <summary>
        ///  Method called after clicking buttonDelete. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // getting index of row selected in dataGridView
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            // getting selected animal id
            int selectedAnimalId = int.Parse(dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString());
            // deleting selected animal from database
            animalsRepository.DeleteAnimal(selectedAnimalId);
            //refreshing dataGridView
            RefreshDataGridView();
        }
        /// <summary>
        ///  Method called after clicking buttonUpdate. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // extracting data from cells in text box and combo boxes
            string newAnimalName = textBoxName.Text;
            string newAnimalClass = comboBoxAnimalClass.Text;
            int newCageNumber = int.Parse(comboBoxCage.Text);
            // getting index of row selected in dataGridView
            int rowIndex = dataGridViewList.CurrentCell.RowIndex;
            // getting selected animal id
            int selectedAnimalId = int.Parse(dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString());
            // updating selected animal using data extracted from text box and combo boxes
            animalsRepository.UpdateAnimal(newAnimalName, newAnimalClass, newCageNumber, selectedAnimalId);
            // refrshing dataGridView
            RefreshDataGridView();
        }
        /// <summary>
        ///  Setting comboBoxCage content depending on comboBoxAnimalClass content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAnimalClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // setting comboBoxCage items to available cages ids
            comboBoxCage.ValueMember = "Id";
            // setting comboBoxCage data source to set of available cages id
            comboBoxCage.DataSource = cagesRepository.GetCagesNames(comboBoxAnimalClass.Text).Tables["Cages"];
        }
        /// <summary>
        /// Setting textBoxes and comboBoxes content depending on clicked cell from dataGridViewList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // checking if content of comboBoxContent is "Animals"
            if (comboBoxContent.SelectedItem.Equals("Animals"))
            {
                // getting index of row selected in dataGridView
                int rowIndex = dataGridViewList.CurrentCell.RowIndex;
                // setting text boxes and combo boxes content to content from selected row
                textBoxName.Text= dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
                comboBoxAnimalClass.Text = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString(); 
                comboBoxCage.Text = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
