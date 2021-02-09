using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad2
{
    public partial class FormMain : Form
    {
        public Random random = new Random();
        // variable to storage amount of food for dogs
        long dogFood = 0;
        // variable to storage amount of food for cats
        long catFood = 0;
        // variable to storage amount of grain for birds
        long grain = 0;
        // variable to define time to next cat meow
        int timeToMeow = 0;
        // variable to define time to next dog bark
        int timeToWoof = 0;
        // variable to define duration time
        int time = 0;
        // definition of list of cats
        List<Cat> cats = new List<Cat>();
        // definition of list of dogs
        List<Dog> dogs = new List<Dog>();
        // definition of list of birds
        List<Bird> birds = new List<Bird>();
        // definition of formEnd
        FormEnd formEnd;
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to refresh information about food in text boxes
        /// </summary>
        private void RefreshFoodTextBoxes()
        {
            // assigning amount of foods to related text boxes
            textBoxDogFood.Text = dogFood.ToString();
            textBoxCatFood.Text = catFood.ToString();
            textBoxGrain.Text = grain.ToString();
        }
        /// <summary>
        /// Method to refresh information in dataGridViewDogs after adding or removing 
        /// </summary>
        private void RefreshDataGridViewDogs()
        {
            //assigning dataGridView source to null
            dataGridViewDogs.DataSource = null;
            //assigning dataGridView source to list of dogs
            dataGridViewDogs.DataSource = dogs;
        }
        /// <summary>
        /// Method to refresh information in dataGridViewCats after adding or removing 
        /// </summary>
        private void RefreshDataGridViewCats()
        {
            //assigning dataGridView source to null
            dataGridViewCats.DataSource = null;
            //assigning dataGridView source to list of cats
            dataGridViewCats.DataSource = cats;
        }
        /// <summary>
        /// Method to refresh information in dataGridViewBirds after adding or removing 
        /// </summary>
        private void RefreshDataGridViewBirds()
        {
            //assigning dataGridView source to null
            dataGridViewBirds.DataSource = null;
            //assigning dataGridView source to list of birds
            dataGridViewBirds.DataSource = birds;
        }
        /// <summary>
        /// Filling text boxes with selected dog attributes
        /// </summary>
        /// <param name="dog"></param>
        private void FillTextBoxesForDog(Dog dog)
        {
            //assigning dog attributes to related text boxes
            textBoxName.Text = dog.Name; 
            textBoxWeight.Text = dog.Weight.ToString();
            textBoxMoodLevel.Text = dog.MoodLevel.ToString();
            textBoxFoodLevel.Text = dog.FoodLevel.ToString();
        }
        /// <summary>
        /// Filling text boxes with selected cat attributes
        /// </summary>
        /// <param name="cat"></param>
        private void FillTextBoxesForCat(Cat cat)
        {
            //assigning cat attributes to related text boxes
            textBoxName.Text = cat.Name;
            textBoxWeight.Text = cat.Weight.ToString();
            textBoxMoodLevel.Text = cat.MoodLevel.ToString();
            textBoxFoodLevel.Text = cat.FoodLevel.ToString();
        }
        /// <summary>
        /// Filling text boxes with selected bird attributes
        /// </summary>
        /// <param name="bird"></param>
        private void FillTextBoxesForBird(Bird bird)
        {
            //assigning bird attributes to related text boxes
            textBoxName.Text = bird.Name;
            textBoxWeight.Text = bird.Weight.ToString();
            textBoxMoodLevel.Text = bird.MoodLevel.ToString();
            textBoxFoodLevel.Text = bird.FoodLevel.ToString();
        }
        /// <summary>
        /// Creating farm - starting program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateFarm_Click(object sender, EventArgs e)
        {
            // adding dog to list
            dogs.Add(new Dog("Doggy"));
            // adding cat to list
            cats.Add(new Cat("Kitty"));
            // adding flying bird to list
            birds.Add(new FlyingBird("Birdie"));
            // assigning dataGridViewDogs source to list of dogs
            dataGridViewDogs.DataSource = dogs;
            // assigning dataGridViewCats source to list of cats
            dataGridViewCats.DataSource = cats;
            // assigning dataGridViewBirds source to list of birds
            dataGridViewBirds.DataSource = birds;
            //generating time to next dog bark randomly
            timeToWoof = random.Next(50,70);
            //generating time to next cat meow randomly
            timeToMeow = random.Next(50,70);
            // starting timer
            timerDuration.Start();
            // refreshing food text boxes
            RefreshFoodTextBoxes();
            // hiding this button because user can create farm only once
            buttonCreateFarm.Hide();
            // showing others button because farm is created
            buttonCreateDog.Show();
            buttonCreateCat.Show();
            buttonCreateBird.Show();
            buttonEditBird.Show();
            buttonEditCat.Show();
            buttonEditDog.Show();
            buttonFindBird.Show();
            buttonFindCat.Show();
            buttonFindDog.Show();
            buttonFeedBird.Show();
            buttonFeedCat.Show();
            buttonFeedDog.Show();
            buttonDeleteDog.Show();
            buttonDeleteBird.Show();
            buttonDeleteCat.Show();
            buttonPlayWithBird.Show();
            buttonPlayWithDog.Show();
            buttonPlayWithCat.Show();
        }
        /// <summary>
        /// Method to checking if it is simulation end
        /// </summary>
        private void StopService()
        {
            //checking if any list is empty
            if (!(dogs.Any() && cats.Any() && birds.Any()))
            {
                // stop timer if at least one list is empty
                timerDuration.Stop();
                // creating formSimulatorWindow
                formEnd = new FormEnd();
                // hiding main window
                this.Hide();
                // showing formSimulatorWindow
                formEnd.ShowDialog();
                // closing main window 
                this.Close();
            }
        }
        /// <summary>
        /// Method to removing animals when they moodLevel or foodLevel is too low
        /// </summary>
        private void DyingService()
        {
            // loop to go through all cats
            for (int i = 0; i < cats.Count; i++)
            {
                // checking if cat should be removed
                if (cats[i].FoodLevel <= 0 || cats[i].MoodLevel <= 0)
                {
                    // choosing cat to remove
                    Cat catToRemove = cats[i];
                    // removing cat from list
                    cats.Remove(catToRemove);
                    // refreshing dataGridViewCats
                    RefreshDataGridViewCats();
                }
            }
            // loop to go through all birds
            for (int i = 0; i < birds.Count; i++)
            {
                // checking if bird should be removed
                if (birds[i].FoodLevel <= 0 || birds[i].MoodLevel <= 0)
                {
                    // choosing bird to remove
                    Bird birdToRemove = birds[i];
                    // removing bird from list
                    birds.Remove(birdToRemove);
                    // refreshing dataGridViewBirds
                    RefreshDataGridViewBirds();
                }
            }
            // loop to go through all dogs
            for (int i = 0; i < dogs.Count; i++)
            {
                // checking if dog should be removed
                if (dogs[i].FoodLevel <= 0 || dogs[i].MoodLevel <= 0)
                {
                    // choosing dog to remove
                    Dog dogToRemove = dogs[i];
                    // removing dog from list
                    dogs.Remove(dogToRemove);
                    // refreshing dataGridViewDogs
                    RefreshDataGridViewDogs();
                }
            }
        }
        /// <summary>
        /// Method to increase amount of foods
        /// </summary>
        private void FoodService()
        {
            // checking if it is time to 
            if (time % 20 == 0)
            {
                //incrementing all food types
                dogFood++;
                catFood++;
                grain++;
                // refreshing information about amount of foods in text boxes
                RefreshFoodTextBoxes();
            }
        }
        /// <summary>
        /// Method to simulate bird behavior
        /// </summary>
        private void BirdBehaviorService()
        {
            // loop to go through all birds
            for (int i = 0; i < birds.Count; i++)
            {
                // checking if it is time to decrement moodLevel and foodLevel
                if (time % 5 == 0)
                {
                    // decrementing bird moodLevel if it is higher than 0 
                    if (birds[i].MoodLevel > 0)
                        birds[i].MoodLevel -= 1;
                    // decrementing bird foodLevel if it is higher than 0 
                    if (birds[i].FoodLevel > 0)
                        birds[i].FoodLevel -= 1;
                }
            }
        }
        /// <summary>
        /// Method to simulate bird behavior
        /// </summary>
        private void CatBehaviorService()
        {
            // loop to go through all cats
            for (int i = 0; i < cats.Count; i++)
            {
                // checking if it is time to decrement moodLevel and foodLevel
                if (time % 5 == 0)
                {
                    // decrementing cat moodLevel if it is higher than 0 
                    if (cats[i].MoodLevel > 0)
                        cats[i].MoodLevel -= 1;
                    // decrementing cat foodLevel if it is higher than 0
                    if (cats[i].FoodLevel > 0)
                        cats[i].FoodLevel -= 1;
                }
                // checking if cat is hungry enough to chasing bird
                if (cats[i].FoodLevel < 10)
                {
                    // choosing bird to chase randomly
                    int birdIndex = random.Next(0, birds.Count);
                    Bird selectedBird = birds[birdIndex];

                    // checking if cat is fast enough to catch bird
                    if (cats[i].Go() > selectedBird.Go())
                    {
                        // removing bird caught by cat
                        birds.Remove(selectedBird);
                        // setting cat foodLevel to 100
                        cats[i].FoodLevel = 100;
                    }
                    else
                    {
                        // if bird will run away from cat its levelMood will be increased
                        selectedBird.Play();
                    }
                }
            }
        }
        /// <summary>
        /// Method to simulate bird behavior
        /// </summary>
        private void DogBehaviorService()
        {
            // loop to go through all dogs
            for (int i = 0; i < dogs.Count; i++)
            {
                // checking if it is time to decrement moodLevel and foodLevel
                if (time % 5 == 0)
                {
                    // decrementing cat moodLevel if it is higher than 0
                    if (dogs[i].MoodLevel > 0)
                        dogs[i].MoodLevel -= 1;
                    // decrementing cat foodLevel if it is higher than 0
                    if (dogs[i].FoodLevel > 0)
                        dogs[i].FoodLevel -= 1;
                }
                // checking if dog is hungry enough to chasing cat
                if (dogs[i].FoodLevel < 10)
                {
                    // choosing cat to chase randomly
                    int catIndex = random.Next(0, cats.Count);
                    Cat selectedCat = cats[catIndex];
                    // checking if dog is fast enough to catch cat
                    if (dogs[i].Go() > selectedCat.Go())
                    {
                        // removing cat caught by dog
                        cats.Remove(selectedCat);
                        // setting dog foodLevel to 100
                        dogs[i].FoodLevel = 100;
                    }
                    else
                    {
                        // if cat will run away from dog its levelMood will be increased
                        selectedCat.Play();
                    }
                }
            }
        }
        /// <summary>
        /// Method to handling sounds made by animals
        /// </summary>
        private void AnimalSoundService()
        {
            // checking if it is time to cat meow
            if (timeToMeow == 0 && cats.Any())
            {
                // choosing which cat will make a sound
                int catIndex = random.Next(0, cats.Count);
                // calling metod Meow on randomly choosen cat
                cats[catIndex].Meow(dogs);
                // setting new time to next meow
                timeToMeow = random.Next(50, 70);
            }
            // checking if it is time to dog bark
            if (timeToWoof == 0 && dogs.Any())
            {
                // choosing which dog will make a sound
                int dogIndex = random.Next(0, dogs.Count);
                // calling metod Woof on randomly choosen dog
                dogs[dogIndex].Woof(cats);
                // setting new time to next bark
                timeToWoof = random.Next(50, 70);
            }
        }
        /// <summary>
        /// Method connected with timer tick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDuration_Tick(object sender, EventArgs e)
        {
            // increasing time
            time++;
            // decreasing time left to meow
            timeToMeow--;
            // decreasing time left to woof
            timeToWoof--;
            // calling method to handle animal sound
            AnimalSoundService();
            // calling method to simulate dogs behavior
            DogBehaviorService();
            // calling method to simulate cats behavior
            CatBehaviorService();
            // calling method to simulate birds behavior
            BirdBehaviorService();
            // calling method to increase amount of food
            FoodService();
            // calling method to removing animals
            DyingService();
            // calling method to check if it is the end of simulation
            StopService();
            // refreshing information in all dataGridView
            dataGridViewBirds.Refresh();
            dataGridViewDogs.Refresh();
            dataGridViewCats.Refresh();
        }
        /// <summary>
        /// Adding dog to list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateDog_Click(object sender, EventArgs e)
        {
            //adding new dog to list
            dogs.Add(new Dog(textBoxName.Text));
            //refreshing dataGridViewDogs
            RefreshDataGridViewDogs();
        }
        /// <summary>
        /// Adding cat to list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateCat_Click(object sender, EventArgs e)
        {
            //adding new cat to list
            cats.Add(new Cat(textBoxName.Text));
            //refreshing dataGridViewCats
            RefreshDataGridViewCats();
        }
        /// <summary>
        /// Adding bird to list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateBird_Click(object sender, EventArgs e)
        {
            //checking if checkBoxFlying is checked- it means that flying bird will be added
            if (checkBoxFlying.Checked)
            {
                //adding new flying bird to list
                birds.Add(new FlyingBird(textBoxName.Text));
            }
            else
            {
                //adding new bird to list
                birds.Add(new Bird(textBoxName.Text));
            }
            //refreshing dataGridViewBirds
            RefreshDataGridViewBirds();
        }
        /// <summary>
        /// Searching for the dog with pointed in text box name and displaying information about it in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindDog_Click(object sender, EventArgs e)
        {
            // finding dog using its name from textBoxName
            Dog dogFound = dogs.Where(x => x.Name == textBoxName.Text).FirstOrDefault();
            // filling text boxes with information about found dog
            FillTextBoxesForDog(dogFound);
        }
        /// <summary>
        /// Searching for the cat with pointed in text box name and displaying information about it in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindCat_Click(object sender, EventArgs e)
        {
            // finding cat using its name from textBoxName
            Cat catFound = cats.Where(x => x.Name == textBoxName.Text).FirstOrDefault();
            // filling text boxes with information about found cat
            FillTextBoxesForCat(catFound);
        }
        /// <summary>
        /// Searching for the bird with pointed in text box name and displaying information about it in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindBird_Click(object sender, EventArgs e)
        {
            // finding bird using its name from textBoxName
            Bird birdFound = birds.Where(x => x.Name == textBoxName.Text).FirstOrDefault();
            // filling text boxes with information about found bird
            FillTextBoxesForBird(birdFound);
        }
        /// <summary>
        /// Removing pointed dog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteDog_Click(object sender, EventArgs e)
        {
            // finding pointed dog 
            Dog dogToRemove = dogs[dataGridViewDogs.CurrentCell.RowIndex];
            // removing pointed dog from list
            dogs.Remove(dogToRemove);
            // refreshing dataGridViewDogs
            RefreshDataGridViewDogs();
        }
        /// <summary>
        /// Removing pointed cat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            // finding pointed cat 
            Cat catToRemove = cats[dataGridViewCats.CurrentCell.RowIndex];
            // removing pointed cat from list
            cats.Remove(catToRemove);
            // refreshing dataGridViewCats
            RefreshDataGridViewCats();
        }
        /// <summary>
        /// Removing pointed bird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteBird_Click(object sender, EventArgs e)
        {
            // finding pointed bird 
            Bird birdToRemove = birds[dataGridViewBirds.CurrentCell.RowIndex];
            // removing pointed bird from list
            birds.Remove(birdToRemove);
            // refreshing dataGridViewBird
            RefreshDataGridViewBirds();
        }
        /// <summary>
        /// Editing pointed dog name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditDog_Click(object sender, EventArgs e)
        {
            // changing pointed dog name to textBoxName content
            dogs[dataGridViewDogs.CurrentCell.RowIndex].Name = textBoxName.Text;
            // refreshing dataGridViewDogs
            dataGridViewDogs.Refresh(); 
        }
        /// <summary>
        /// Editing pointed cat name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditCat_Click(object sender, EventArgs e)
        {
            // changing pointed cat name to textBoxName content
            cats[dataGridViewCats.CurrentCell.RowIndex].Name = textBoxName.Text;
            // refreshing dataGridViewCats
            dataGridViewCats.Refresh();
        }
        /// <summary>
        /// Editing pointed bird name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBird_Click(object sender, EventArgs e)
        {
            // changing pointed bird name to textBoxName content
            birds[dataGridViewBirds.CurrentCell.RowIndex].Name = textBoxName.Text;
            // refreshing dataGridViewBirds
            dataGridViewBirds.Refresh();
        }
        /// <summary>
        /// Displaying information about pointed dog in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // choosing pointed dog from list  
            Dog selectedDog = dogs[dataGridViewDogs.CurrentCell.RowIndex];
            // filling text boxes with pointed dog information
            FillTextBoxesForDog(selectedDog);

        }
        /// <summary>
        /// Displaying information about pointed cat in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewCats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // choosing pointed cat from list
            Cat selectedCat = cats[dataGridViewCats.CurrentCell.RowIndex];
            // filling text boxes with pointed cat information
            FillTextBoxesForCat(selectedCat);
        }
        /// <summary>
        /// Displaying information about pointed bird in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewBirds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // choosing pointed bird from list
            Bird selectedBird = birds[dataGridViewBirds.CurrentCell.RowIndex];
            // filling text boxes with pointed bird information
            FillTextBoxesForBird(selectedBird);
        }
        /// <summary>
        /// Playing with pointed dog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayWithDog_Click(object sender, EventArgs e)
        {
            // calling method Play on pointed dog 
            dogs[dataGridViewDogs.CurrentCell.RowIndex].Play();
            // refreshing dataGridViewDogs
            dataGridViewDogs.Refresh();
        }
        /// <summary>
        /// Playing with pointed cat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayWithCat_Click(object sender, EventArgs e)
        {
            // calling method Play on pointed cat 
            cats[dataGridViewCats.CurrentCell.RowIndex].Play();
            // refreshing dataGridViewCats
            dataGridViewCats.Refresh();
        }
        /// <summary>
        /// Playing with pointed bird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayWithBird_Click(object sender, EventArgs e)
        {
            // calling method Play on pointed bird 
            birds[dataGridViewBirds.CurrentCell.RowIndex].Play();
            // refreshing dataGridViewBirds
            dataGridViewBirds.Refresh();
        }
        /// <summary>
        /// Feeding pointed dog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeedDog_Click(object sender, EventArgs e)
        {
            // checking if there is enough food to feed pointed dog
            if (dogFood >= dogs[dataGridViewDogs.CurrentCell.RowIndex].Feed())
            {
                // reducing amount of dog food and setting pointed dog foodLevel to 100
                dogFood -= dogs[dataGridViewDogs.CurrentCell.RowIndex].Feed();
            }
            // refreshing information in food text boxes
            RefreshFoodTextBoxes();
        }
        /// <summary>
        /// Feeding pointed cat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeedCat_Click(object sender, EventArgs e)
        {
            // checking if there is enough food to feed pointed cat
            if (catFood >= cats[dataGridViewCats.CurrentCell.RowIndex].Feed())
            {
                // reducing amount of cat food and setting pointed cat foodLevel to 100
                catFood -= cats[dataGridViewCats.CurrentCell.RowIndex].Feed();
            }
            // refreshing information in food text boxes
            RefreshFoodTextBoxes();
        }
        /// <summary>
        /// Feeding pointed bird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeedBird_Click(object sender, EventArgs e)
        {
            // checking if there is enough food to feed pointed bird
            if (grain >= birds[dataGridViewBirds.CurrentCell.RowIndex].Feed())
            {
                // reducing amount of grain and setting pointed bird foodLevel to 100
                grain -= birds[dataGridViewBirds.CurrentCell.RowIndex].Feed();
            }
            // refreshing information in food text boxes
            RefreshFoodTextBoxes();
        }
        /// <summary>
        /// Loading formMain
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // hiding all buttons except buttonCreateFarm because user cant use any of this before creating farm
            buttonCreateDog.Hide();
            buttonCreateCat.Hide();
            buttonCreateBird.Hide();
            buttonEditBird.Hide();
            buttonEditCat.Hide();
            buttonEditDog.Hide();
            buttonFindBird.Hide();
            buttonFindCat.Hide();
            buttonFindDog.Hide();
            buttonFeedBird.Hide();
            buttonFeedCat.Hide();
            buttonFeedDog.Hide();
            buttonDeleteDog.Hide();
            buttonDeleteBird.Hide();
            buttonDeleteCat.Hide();
            buttonPlayWithBird.Hide();
            buttonPlayWithDog.Hide();
            buttonPlayWithCat.Hide();
        }
    }
}
