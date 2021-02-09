using System;
using System.Drawing;
using System.Windows.Forms;

namespace HalszkaCiesielskaZad1
{
    public partial class FormSimulatorWindow : Form
    {
        Random random = new Random();
        // variable to storage game duration time
        int time = 0; 
        // variable to storage amount of beavers in village
        int amountOfBeavers = 10;
        // variable to storage amount of wood 
        int amountOfWood = 0;
        // variable to storage amount of food
        int amountOfFood = 0;
        //  variable to storage amount of blueberries
        int amountOfBlueberries = 0;
        //  variable to storage amount of juice
        int amountOfJuice = 0;
        //  variable to storage amount of gold
        int amountOfGold = 0;
        //  variable to storage amount of dams
        int amountOfDam = 0;

        // variable to storage the amount of wood collected per second 
        // it can be improved by going to the dentist and drinking juice
        int woodPerSecond = 10;
        // variable to storage remaining time to the flood
        int timeToFlood = 0;
        // variable to storage the force of incoming flood
        int floodForce = 0;
        // variable to storage amount of beavers to kill by flood or hunger
        int beaversToKill = 0;

        // variable to storage read from numericUpDown amount of gold to buy 
        int goldToBuy = 0;
        // variable to storage read from numericUpDown amount of food to buy 
        int foodToBuy = 0;
        // variable to storage read from numericUpDown amount of beavers going to dentist
        int beaversToDentist = 0;
        // variable to storage read from numericUpDown amount of juice to drink
        int juiceToDrink = 0;
        // variable to storage read from numericUpDown amount of dam to build 
        int damToBulid = 0;

        // variable to storage time remaining to next feeding 
        int timeToFeed = 0;
        // variable to storage how often beavers should be fed
        int feedTime = 60; 
        // variable to storage time remaining to new beavers birth 
        int timeToBorn = 0;
        // variable to storage how often beavers are born 
        int bornTime = 90; 

        // variable to define the cost of one gold (in wood) 
        int woodsForGold = 5;
        // variable to define the cost of one portion of food (in gold) 
        int goldForFood = 3;
        // variable to define the cost od dentist appointment (in gold) 
        int goldForDentist = 15;
        // variable to define the cost of dam (in wood)
        int woodsForDam = 15;

        // variable to define how often wood are generated
        int woodGenerationTime = 3;
        // variable to define how often blueberries are generated
        int blueberriesGenerationTime = 5; 
        //variable to define how many blueberries are needed for one juice
        int blueberriesForJuice = 5;

        // definition of formEndGame 
        FormEndGame formEndGame; 

        // variable to storage text to display
        public string textToDisplay = "";
        public FormSimulatorWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loading formSimulatorWindow. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSimulatorWindow_Load(object sender, EventArgs e)
        {
            // assigning text to label 
            labelName.Text = textToDisplay;
            // starting timer 
            timerGameDuration.Start();

        }
        /// <summary>
        /// Function to handle flood. 
        /// </summary>
        private void FloodService()
        {
            // checking if it is flood time
            if (timeToFlood == 0)
            {
                // checking if there is enough dams to protect all of beavers
                if (amountOfDam > floodForce)
                {
                    // reducing amount of dams
                    amountOfDam -= floodForce;
                }
                else
                {
                    // setting how many beavers will be killed by flood
                    beaversToKill = floodForce - amountOfDam;

                    // checking if there is less beavers to kill than all of beavers
                    if (beaversToKill < amountOfBeavers)
                    {
                        // reducing wood per second because of beavers death
                        woodPerSecond = (woodPerSecond / amountOfBeavers) * (amountOfBeavers - beaversToKill) + (woodPerSecond - beaversToKill) % (woodPerSecond / amountOfBeavers);
                        // reducing amount of beavers
                        amountOfBeavers -= beaversToKill;
                        // setting amount of dam to 0 
                        amountOfDam = 0;
                       
                    }
                    else
                    {
                        // setting amount of beavers to 0 
                        amountOfBeavers = 0;
                    }
                }

                // randomly setting time to next flood
                timeToFlood = random.Next(60, 180);
                // randomly setting next flood force
                floodForce = random.Next(1, amountOfBeavers);
                // setting font color to black
                textBoxFlood.ForeColor = Color.Black;
                // refreshing information in text boxes
                textBoxAmountOfBeavers.Text = amountOfBeavers.ToString();
                textBoxAmountOfDams.Text = amountOfDam.ToString();
            }

            // decrement time to next flood
            timeToFlood--;
            // checking if there is less than 11 seconds to next flood
            if (timeToFlood < 11)
            {
                // setting font color to red
                textBoxFlood.ForeColor = Color.Red;

            }
            //refreshing information about flood in text box
            textBoxFlood.Text = timeToFlood.ToString();

        }
        /// <summary>
        /// Function to generate wood. 
        /// </summary>
        private void WoodGeneration()
        {
            // checking if it is time to generate wood
            if (time % woodGenerationTime == 0)
            {
                // increasing amount of wood
                amountOfWood += woodPerSecond;
                // refreshing information about wood in text box
                textBoxAmountOfWood.Text = amountOfWood.ToString();
            }
        }
        /// <summary>
        /// Funtion to generate blueberries and juice
        /// </summary>
        private void BlueberriesGeneration()
        {
            // checking if it is time to generate blueberry 
            if (time % blueberriesGenerationTime == 0)
            {
                // increment amount of blueberries
                amountOfBlueberries++;
                // checking if there is enough blueberries to make juice
                if (amountOfBlueberries == blueberriesForJuice)
                {
                    // setting amount of blueberries to 0 
                    amountOfBlueberries = 0;
                    // increment amount of juice
                    amountOfJuice++;
                    // refreshing information about juice in text box
                    textBoxAmountOfJuice.Text = amountOfJuice.ToString();

                }
                // refreshing information about blueberries in text box
                textBoxAmountOfBlueberries.Text = amountOfBlueberries.ToString();
            }
        }
        /// <summary>
        /// Function to handle feeding beavers
        /// </summary>
        private void FeedingService()
        {
            // checking if it is time to feed beavers
            if (time % feedTime == 0)
            {
                // checking if there is enough food to feed all of beavers
                if (amountOfFood >= amountOfBeavers)
                {
                    // reducing amount of food
                    amountOfFood -= amountOfBeavers;
                }
                else
                {
                    // checking how many beavers will be starving 
                    beaversToKill = amountOfBeavers - amountOfFood;

                    // checking if there is less starving beavers than all of beavers
                    if (beaversToKill < amountOfBeavers)
                    {
                        // reducing wood per second because of beavers death
                        woodPerSecond = (woodPerSecond / amountOfBeavers) * (amountOfBeavers - beaversToKill) + (woodPerSecond - beaversToKill) % (woodPerSecond / amountOfBeavers);
                        // reducing amount of beavers
                        amountOfBeavers -= beaversToKill;
                        // setting amount of food to 0 
                        amountOfFood = 0;

                    }
                    else
                    {
                        // setting amount of beavers to 0 
                        amountOfBeavers = 0;

                    }
                }
                // setting font color to black
                textBoxFeedingTime.ForeColor = Color.Black;
                // refreshing information in text boxes
                textBoxAmountOfBeavers.Text = amountOfBeavers.ToString();
                textBoxAmountOfFood.Text = amountOfFood.ToString();
            }
            // refreshing time to next feeding
            timeToFeed = feedTime - time % feedTime;

            // checking if there is less than 11 seconds to next feeding
            if (timeToFeed < 11)
            {
                // setting font color to red
                textBoxFeedingTime.ForeColor = Color.Red;
            }
            // refreshing infromation in text box 
            textBoxFeedingTime.Text = timeToFeed.ToString();

        }
        /// <summary>
        /// Function to handle the birth of new beavers
        /// </summary>
        private void BirthService()
        {
            // checking if it is time to born new beavers 
            if (time % bornTime == 0)
            {
                // randomly increasing amount of beavers
                amountOfBeavers += random.Next(0, amountOfBeavers / 2 + 1);
                // refreshing information in text box
                textBoxAmountOfBeavers.Text = amountOfBeavers.ToString();
            }

            // refreshing time to next beavers birth
            timeToBorn = bornTime - time % bornTime;
            // refreshing information in text box
            textBoxTimeToBorn.Text = timeToBorn.ToString();

        }
        /// <summary>
        /// End game function 
        /// </summary>
        private void GameEnding()
        {
            if (amountOfBeavers == 0)
            {
                // stop timer
                timerGameDuration.Stop();
                // creating formSimulatorWindow
                formEndGame = new FormEndGame();
                // displaying welcome text
                formEndGame.textEndToDisplay = "Unfortunatelly, none of your beavers survived.\nYour game ended after " + time + " seconds of amazing adventure!";
                // hiding main window
                this.Hide();
                // showing formSimulatorWindow
                formEndGame.ShowDialog();
                // closing main window 
                this.Close();
            }
        }
        /// <summary>
        /// Function defining events connected with timer tick 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGameDuration_Tick(object sender, EventArgs e)
        {
            // timer incrementation
            time++;

            // calling all funtions conected with time
            WoodGeneration();
            BlueberriesGeneration();
            FloodService();
            FeedingService();
            BirthService();

            // killing the last of the beavers because there is no chance to born new beavers
            if (amountOfBeavers == 1) amountOfBeavers = 0; 
            // checking if the game should end
            GameEnding(); 
            
        }

        /// <summary>
        /// Function to define action after clicking buttonWoodToGold.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWoodToGold_Click(object sender, EventArgs e)
        {
            // loading amount of gold to buy
            goldToBuy = Int32.Parse(numericUpDownGoldToBuy.Text);

            // checking if there is enough wood to buy gold
            if (goldToBuy * woodsForGold <= amountOfWood)
            {
                // increasing amount of gold
                amountOfGold += goldToBuy;
                // reducing amount of wood
                amountOfWood -= goldToBuy * woodsForGold;
                
            }
            // checking if tere is enough wood to buy at least one gold
            else if (amountOfWood / woodsForGold > 0)
            {
                // setting new amount of gold to buy
                goldToBuy = amountOfWood / woodsForGold;
                // increasing amount of gold
                amountOfGold += goldToBuy;
                // reducing amount of wood
                amountOfWood -= goldToBuy * woodsForGold;
            }
            // refreshing information in text box
            textBoxAmountOfWood.Text = amountOfWood.ToString();
            textBoxAmountOfGold.Text = amountOfGold.ToString();
        }
        /// <summary>
        /// Function to define action after clicking buttonBuyFood.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFood_Click(object sender, EventArgs e)
        {
            // loading amount of food to buy
            foodToBuy = Int32.Parse(numericUpDownFoodToBuy.Text);

            // checking if there is enough gold to buy food
            if (foodToBuy* goldForFood <= amountOfGold)
            {
                //  reducing amount of gold
                amountOfGold -= foodToBuy* goldForFood;
                // increasing amount of food
                amountOfFood += foodToBuy;

            }
            // checking if tere is enough gold to buy food for at least one beaver
            else if (amountOfGold / goldForFood > 0)
            {
                // setting new amount of food to buy
                foodToBuy = amountOfGold / goldForFood;
                // reducing amount of gold 
                amountOfGold -= foodToBuy* goldForFood;
                // increasing amount of food
                amountOfFood += foodToBuy;
            }
            // refreshing information in text box
            textBoxAmountOfFood.Text = amountOfFood.ToString();
            textBoxAmountOfGold.Text = amountOfGold.ToString();
        }
        /// <summary>
        /// Function to define action after clicking buttonImproveTeeth.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImproveTeeth_Click(object sender, EventArgs e)
        {
            // loading amount of beavers going to the dentist from numericUpDown
            beaversToDentist = Int32.Parse(numericUpDownDentist.Text);

            // checking if there is enough gold to make beavers dentist appointment
            if (beaversToDentist* goldForDentist <= amountOfGold) {

                // reducing amount of gold 
                amountOfGold -= beaversToDentist * goldForDentist;
                // increasing amount of woods per second
                woodPerSecond += beaversToDentist * 2; 
            }
            // checking if tere is enough gold to make an appointment for at least one beaver
            else if (amountOfGold / goldForDentist > 0)
            {
                // setting new amount of beavers sending to dentist
                beaversToDentist = amountOfGold / goldForDentist;
                // reducing amount of gold 
                amountOfGold -= beaversToDentist * goldForDentist;
                // increasing amount of woods per second
                woodPerSecond += beaversToDentist * 2;
            }
            // refreshing information in text box
            textBoxAmountOfGold.Text = amountOfGold.ToString();
        }
        /// <summary>
        /// Function to define action after clicking buttonDrinkJuice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrinkJuice_Click(object sender, EventArgs e)
        {
            // loading amount of juices to drink from numericUpDown
            juiceToDrink = Int32.Parse(numericUpDownJuice.Text);

            // checking if there is enough juice to drink 
            if (juiceToDrink <= amountOfJuice)
            {
                // increasing amount of woods per second
                woodPerSecond += juiceToDrink;
                // reducing the amount of juice
                amountOfJuice -= juiceToDrink; 
            }
            else
            {
                // increasing amount of woods per second by amount of juice
                woodPerSecond += amountOfJuice;
                // reducing the amount of juice to 0 
                amountOfJuice = 0; 
            }
            // refreshing information in text box
            textBoxAmountOfJuice.Text = amountOfJuice.ToString();
        }
        /// <summary>
        /// Function to define action after clicking buttonBulidDam.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBulidDam_Click(object sender, EventArgs e)
        {
            // loading amount of dams to build from numericUpDown
            damToBulid = Int32.Parse(numericUpDownDam.Text);

            // checking if there is enough wood to build idicated amount of dams
            if (damToBulid * woodsForDam <= amountOfWood)
            {
                // increasing the amount of dams
                amountOfDam += damToBulid;
                // reducing the amount of wood 
                amountOfWood -= damToBulid * woodsForDam;

            }
            // checking if there is enough wood to build at least 1 dam 
            else if (amountOfWood / woodsForDam > 0)
            {
                // setting new amount of dam to build 
                damToBulid = amountOfWood / woodsForDam;
                // increasing the amount of dams
                amountOfDam += damToBulid;
                // reducing the amount of wood 
                amountOfWood -= damToBulid * woodsForDam;
            }

            // refreshing informations in text boxes 
            textBoxAmountOfWood.Text = amountOfWood.ToString();
            textBoxAmountOfDams.Text = amountOfDam.ToString();

        }

    }
}
