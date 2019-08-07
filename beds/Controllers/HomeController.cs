//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: Flow control logic for the bed management project given by Oculys
 */

using beds.Models;
using beds.ViewModels;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IBedRepository _bedRepository;
        List<Patients> _patientList = new List<Patients>();

        public HomeController(IPatientRepository patientRepository, IBedRepository bedRepository)
        { //constructor injection
            _patientRepository = patientRepository;
            _bedRepository = bedRepository;
        }


        public ViewResult Index()
        {//index view, default page upon startup
            var model = _patientRepository.GetAllPatient();
            return View(model);

        }

        public ViewResult Details(int? id)
        {//startup for the Home/Details webpage
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {//sets up the biew model for the details page
                Patients = _patientRepository.GetPatient(id ?? 1),
                PageTitle = "Patient Details"
            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {//startup for when the user opens Home/Create
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patients patients)
        {//overloads Create for when the page sends Patient class data over a HttpPost request
            
            if (ModelState.IsValid)
            {
                var today = DateTime.Today; 
                var age = today.Year - patients.DOB.Year;
                if (patients.DOB.Date > today.AddYears(-age))
                    age--;
                patients.Age = age;//^uses the patients birth date to calculate their age upon creation^

                patients.Location = "";//sets the patients location data to its defaul value so it gets handled properly by manager view
                Patients newPatient = _patientRepository.AddPatient(patients); 


                var complete = _patientRepository.GetAllPatient().OrderByDescending(e => e.timeMinutes);
                _patientList = complete.ToList();
                _patientRepository.UpdatePatients(_patientList);//updates the list of patients as well as sorts them in order of longest wait-time to shortest

                using (var writer = new StreamWriter("wwwroot/Patients.csv"))
                using (var csv = new CsvWriter(writer))//begins the csv writter to be used and discarded
                {
                    csv.WriteRecords(_patientList);//writes the new list to the csv to save new info
                }
                return RedirectToAction("details", new { id = newPatient.ID });//redirects the user to Details page for the newly created patient
            }

            return View();
        }
        public ActionResult Manager()
        {//startup for when the user opens Home/Manager
            //uses dynamic model creation to pass both the patient list and the beds list to the manager view
            var modelA = _patientRepository.GetAllPatient();
            var modelB = _bedRepository.GetAllBeds();
            bedPatientModel model = new bedPatientModel();
            model._patient = modelA;
            model._beds = modelB;

            return View(model);
        }

        [HttpPost]
        public IActionResult Manager(string beingDragged,string droppedIn)
        {//overloads Manager for when the save bed button is clicked, takes 2 strings from Manager.cshtml
            if (ModelState.IsValid && beingDragged != null && droppedIn != null)//server side validation for the 2 args because client side was not working
            {
                var target = _patientRepository.GetPatient(int.Parse(beingDragged));
                if (droppedIn == "container")
                {//if the patient was moved back to the container, set the location to the default value
                    target.Location = "";
                }
                else
                {//else sets the patient location
                    target.Location = droppedIn;
                }

                using (var writer = new StreamWriter("wwwroot/Patients.csv"))
                using (var csv = new CsvWriter(writer))//begins the csv writter to be used and discarded
                {//writes the new list to the csv to save new info
                    csv.WriteRecords(_patientRepository.GetAllPatient());
                }
            }
            return RedirectToAction("manager");//redirects back to the patient manager page
        }
    }
}
