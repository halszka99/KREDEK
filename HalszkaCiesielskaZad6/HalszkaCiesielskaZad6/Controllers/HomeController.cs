using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HalszkaCiesielskaZad6.Models;
using Microsoft.AspNetCore.Mvc;

namespace HalszkaCiesielskaZad6.Controllers
{
    public class HomeController : Controller
    {
        //initialization of list of employees with example data
        static List<EmployeeViewModel> employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                FirstName = "Nick",
                LastName = "Smith",
                Profession = "caregiver",
                Salary = 10000
            },
            new EmployeeViewModel
            {
                FirstName = "Jordan",
                LastName = "Williams",
                Profession = "feeder",
                Salary = 7000
            },
            new EmployeeViewModel
            {
                FirstName = "Maria",
                LastName = "Anderson",
                Profession = "cleaner",
                Salary = 8000
            }
        };
        //initialization of list of animals with example data
        static List<AnimalViewModel> animals = new List<AnimalViewModel>
        {
            new AnimalViewModel
            {
                Name = "Kiara",
                AnimalClass = "lion",
                Cage = 1
            },
            new AnimalViewModel
            {
                Name = "Bob",
                AnimalClass = "giraffe",
                Cage = 2
            },
            new AnimalViewModel
            {
                Name = "Diego",
                AnimalClass = "seal",
                Cage = 3
            }
        };
        //initialization of list of events with example data
        static List<EventViewModel> events = new List<EventViewModel>
        {
            new EventViewModel
            {
                Animal = animals.Where(a => a.Name == "Kiara").FirstOrDefault(),
                Date = new DateTime(2021, 01, 31),
                Time = new TimeSpan(15, 00, 00),
                TicketPrice = 10
            },
            new EventViewModel
            {
                Animal = animals.Where(a => a.Name == "Bob").FirstOrDefault(),
                Date = new DateTime(2021, 01, 31),
                Time = new TimeSpan(16, 00, 00),
                TicketPrice = 15
            },
            new EventViewModel
            {
                Animal = animals.Where(a => a.Name == "Diego").FirstOrDefault(),
                Date = new DateTime(2021, 01, 31),
                Time = new TimeSpan(17, 00, 00),
                TicketPrice = 5
            }
        };
        //HomeController constructor 
        public HomeController()
        {
        }
        /// <summary>
        /// Home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //keeping created tempData
            TempData.Keep("LastAddedEvent");
            TempData.Keep("LastAddedAnimal");
            TempData.Keep("LastAddedEmployee");
            // returning IndexView
            return View();
        }
        /// <summary>
        /// Animals list view
        /// </summary>
        /// <returns></returns>
        public IActionResult AnimalsList()
        {
            //returning AnimalsListView with list of animals
            return View(animals);
        }
        /// <summary>
        /// Employees list view
        /// </summary>
        /// <returns></returns>
        public IActionResult EmployeesList()
        {
            //returning EmployeesListView with list of employees
            return View(employees);
        }
        /// <summary>
        ///  Events list view
        /// </summary>
        /// <returns></returns>
        public IActionResult EventsList()
        {
            //returning EventsListView with list of events
            return View(events);
        }
        /// <summary>
        /// Add event view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddEvent()
        {
            // returning AddEventView
            return View();
        }
        /// <summary>
        /// Add event view with addedEvent
        /// </summary>
        /// <param name="addedEvent"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddEvent(EventViewModel addedEvent)
        {
            try
            {
                // converting animal name to correct format
                string name = addedEvent.Animal.Name[0].ToString().ToUpper() + addedEvent.Animal.Name.Substring(1).ToLower();
                // setting addedEvent animal to animal with given name
                addedEvent.Animal = animals.Where(a => a.Name == name).FirstOrDefault();
                // adding event to event list 
                events.Add(addedEvent);
                // creating viewbags
                ViewBag.Animal = addedEvent.Animal.Name;
                ViewBag.Date = addedEvent.Date.ToString("d");
                ViewBag.Time = addedEvent.Time.ToString("hh\\:mm");
                ViewBag.Price = addedEvent.TicketPrice;
                // creating tempdata
                TempData["LastAddedEvent"] = addedEvent.Date.ToString("d") + " " + addedEvent.Time.ToString("hh\\:mm");
                // returning EventAddedView
                return View("EventAdded");
            }
            catch
            {
                //returning AddEventView if adding event failed
                return View();
            }
        }
        /// <summary>
        /// Add animal view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddAnimal()
        {
            // returning AddAnimalView
            return View();
        }
        /// <summary>
        /// Add animal view with addedAnimal
        /// </summary>
        /// <param name="addedAnimal"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddAnimal(AnimalViewModel addedAnimal)
        {
            try
            {
                //setting addedAnimal name to correct format
                addedAnimal.Name = addedAnimal.Name[0].ToString().ToUpper() + addedAnimal.Name.Substring(1).ToLower();
                addedAnimal.AnimalClass = addedAnimal.AnimalClass.ToLower();
                //adding animal to animal list
                animals.Add(addedAnimal);
                // creating viewbags
                ViewBag.AnimalName = addedAnimal.Name;
                ViewBag.AnimalClass = addedAnimal.AnimalClass;
                ViewBag.AnimalCage = addedAnimal.Cage;
                // creating tempdata
                TempData["LastAddedAnimal"] = addedAnimal.AnimalClass + " " + addedAnimal.Name;
                //returning AnimalAddedView
                return View("AnimalAdded");
            }
            catch 
            {
                //returning AddAnimalView if adding animal failed
                return View();
            }
        }
        /// <summary>
        /// Add employee view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddEmployee()
        {
            // returning AddEmployeeView
            return View();
        }
        /// <summary>
        /// Add employee view with addedEmployee
        /// </summary>
        /// <param name="addedEmployee"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel addedEmployee)
        {
            try
            {
                // setting added employee properties to correct format
                addedEmployee.FirstName = addedEmployee.FirstName[0].ToString().ToUpper() + addedEmployee.FirstName.Substring(1).ToLower();
                addedEmployee.LastName = addedEmployee.LastName[0].ToString().ToUpper() + addedEmployee.LastName.Substring(1).ToLower();
                addedEmployee.Profession = addedEmployee.Profession.ToLower(); 
                // adding employee to employees list
                employees.Add(addedEmployee);
                // creating string name
                string name = addedEmployee.FirstName + " " + addedEmployee.LastName;
                // creating viewbags
                ViewBag.Name = name; 
                ViewBag.Profession = addedEmployee.Profession;
                // creating tempdata
                TempData["LastAddedEmployee"] = name;
                // returning EmployeeAddedView
                return View("EmployeeAdded");
            }
            catch
            {
                //returning AddEmployeeView if adding employee failed
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
