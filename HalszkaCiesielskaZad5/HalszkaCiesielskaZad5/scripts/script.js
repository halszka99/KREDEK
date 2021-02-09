//id of foodInterval 
let foodInterval = 0;
//id of healthInterval
let healthInterval = 0; 
//id of winTimeout
let winTimeout = 0; 
//amount of gold 
let goldAmount = 0; 
//table with amounts of food and pills
let amounts = [0, 0];
//table with prices of food and pills
let prices = [10, 20];
//table with levels of food and health 
let levels = [100, 100];
//varaible to define if start button was clicked
let clicked = false; 
//array with best times 
let bestTimes = [0, 0, 0, 0, 0];
//start of game
let timeStart = 0;
//duration of game
let duration = 0; 

//function to set and start progress bars 
function SetBars() {
    //setting progress bars values
    document.getElementsByTagName("progress")[0].value = levels[0]; 
    document.getElementsByTagName("progress")[1].value = levels[1]; 
    // calling setInterval to food progress bar
    foodInterval = setInterval(ProgessBar,300, 0);
    // calling setInterval to pills progress bar
    healthInterval = setInterval(ProgessBar, 500, 1);
}
//funtion to change progress bar value
function ProgessBar(i) {
    // chcecking if level is equal to 0
    if (levels[i] == 0) {
        // if it is player lost
        Lost();
    }
    else {
        //decresing level
        levels[i]--;
        //setting progress bar value to new value 
        document.getElementsByTagName("progress")[i].value = levels[i];
    }
}
//function to start game
function Game() {
    //chcecking if button start was clicked
    if (clicked == true) {
        //adding new event listener to button start
        document.getElementById("start-button").addEventListener("click", alert("You already started"));
    }
    else
    {
        //setting clicked to true
        clicked = true;
        //setting progress bars
        SetBars();
        //setting timeout to win game
        winTimeout = setTimeout(Win, 180000);
        //starting game
        timeStart = new Date().getTime();
        //checking if there is something in item bestTimes in localStorage 
        if (JSON.parse(localStorage.getItem('bestTimes')) != null) {
            // if item bestTimes in localStorage is not null then setting bestTimes to this item
            bestTimes = JSON.parse(localStorage.getItem('bestTimes'));
        }

        //adding event listeners on click to feed button
        document.getElementById("feed-button").addEventListener("click", function () { HelpBeaver(0) });
        document.getElementById("feed-button").addEventListener("click", FoodLevel);
        //adding event listeners on click to cure button
        document.getElementById("cure-button").addEventListener("click", function () { HelpBeaver(1) });
        document.getElementById("cure-button").addEventListener("click", PillsLevel);
        //adding event listeners on click to food image
        document.getElementById("food-img").addEventListener("click", function () { Buy(0) });
        document.getElementById("food-img").addEventListener("click", FoodLevel);
        document.getElementById("food-img").addEventListener("click", GoldLevel);
        //adding event listeners on click to pills image
        document.getElementById("pills-img").addEventListener("click", function () { Buy(1) });
        document.getElementById("pills-img").addEventListener("click", PillsLevel);
        document.getElementById("pills-img").addEventListener("click", GoldLevel);
        //adding event listeners on click to beaver image
        document.getElementById("beaver-img").addEventListener("click", EarnMoney);
        document.getElementById("beaver-img").addEventListener("click", GoldLevel);
        //adding event listeners on mouse over to progress bars
        document.getElementById("food-bar").addEventListener("mouseover", function () { Title(0) });
        document.getElementById("health-bar").addEventListener("mouseover", function () { Title(1) });
    }
}
//function to set title of progress bars
function Title(i) {
    //adding title to progress bar
    document.getElementsByTagName("progress")[i].title = levels[i];
}
//function called after winning
function Win() {
    //alert with congratulations
    alert("CONGRATULATIONS");
    //calling function End
    End();
}
//function called after failure
function Lost() {
    //alert with information about failure
    alert("Your beaver died");
    //calling function End
    End();
}
//function to increase level of food or health
function HelpBeaver(i) {
    //chcecking if there is enough resources 
    if (amounts[i] > 0) {
        //increasing level
        levels[i] += 5;
        //update value in progress bar
        document.getElementsByTagName("progress")[i].value = levels[i];
        //decreasing amount of resource
        amounts[i]--; 
    }
    else
    {
        //no resources alert
        alert("You don't have resources");
    }
}
//function to buy item
function Buy(i) {
    //checking if there is enough gold to buy resource
    if (goldAmount >= prices[i]) {
        //increasing amount of resource
        amounts[i]++;
        //decreasing amount of gold by price
        goldAmount -= prices[i];
    }
    else
    {
        //no money alert
        alert("You don't have money");
    }
}
//function to earn money
function EarnMoney() {
    //increasing amount of gold
    goldAmount++;
}
//function called after ending game
function End() {
    //calculating duration
    duration = new Date().getTime() - timeStart;
    //adding time to array
    AddToBestTime(duration); 
    //clearing intervals and timeout
    clearInterval(foodInterval);
    clearInterval(healthInterval);
    clearTimeout(winTimeout);
    //setting clicked to false
    clicked = false;
    //setting levels and amounts to default values
    levels = [100, 100];
    amounts = [0, 0];
    goldAmount = 0;
}
//function to update amount of food
function FoodLevel() {
    //updating amount of food
    document.getElementById("food-level").innerHTML = amounts[0]; 
}
//function to update amount of pills
function PillsLevel() {
    //updating amount of pills
    document.getElementById("pills-level").innerHTML = amounts[1];
}
//function to update amount of gold
function GoldLevel() {
    //updating amount of gold
    document.getElementById("gold-level").innerHTML = goldAmount;
}
//function to add current time to array with best times
function AddToBestTime(time)
{
    //pushing new time to array
    bestTimes.push(time);
    //sorting array
    bestTimes.sort(function (a, b) { return b - a });
    //cutting array to 5 elements
    if (bestTimes.length > 5)
        bestTimes.pop(); 
    //clearing local storage
    localStorage.clear();
    //adding array with best times to localStorage 
    localStorage.setItem('bestTimes', JSON.stringify(bestTimes));
}
//function to show table with best times
function ShowTable() {
    //initialization of array with best times from localStorage 
    let times = JSON.parse(localStorage.getItem('bestTimes'));

    //creating table with best times
    document.getElementById("times-table").innerHTML = "";

    document.getElementById("times-table").innerHTML +=
        '<thead>' +
            '<tr>' +
                '<th class="text-center"> Place </th>' +
                '<th class="text-center"> Time </th>' +
            '</tr>' +
        '</thead>' +
        '<tbody>';

    if (times != null)
    {
        for (let i = 0; i < 5; i++) {
            document.getElementById("times-table").innerHTML +=
                '<tr>' +
                '<td class="text-center">' + (i + 1) + ' </td>' +
                '<td class="text-center"> ' + times[i] + ' ms' + '</td>' +
                '</tr>';
        }

        document.getElementById("times-table").innerHTML +=
            '</tbody>';
    }


    if (times == null) {
        //hidding table if it is empty
        document.getElementById("times-table").style.visibility = "hidden";
    }
}