//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: Contains the method definitions for the IPatientRepository Interface
 */
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public class MockPatientRepository : IPatientRepository
    {
        List<Patients> _patientList = new List<Patients>();

        public MockPatientRepository()
        {//constructor for the PatientRepository class
        //this function will read the csv file Patients.csv, parse the data and stores it in a list to be used throughout the application
            using (var reader = new StreamReader("wwwroot/Patients.csv"))
            using (var csv = new CsvReader(reader))
            {
                var listOfPatients = csv.GetRecords<PatientInput>();


                foreach (var p in listOfPatients)
                {//builds each individual patient then adds them to the list
                    Patients patientToAdd = new Patients();
                    try
                    {
                        patientToAdd.DOB = DateTime.Parse(p.DOB);
                    }
                    catch
                    {
                        //
                    }
                    patientToAdd.ID = int.Parse(p.ID);
                    patientToAdd.Sex = p.Sex;


                    patientToAdd.WaitTime = p.WaitTime;
                    


                    patientToAdd.Location = p.Location;
                    var today = DateTime.Today;
                    var age = today.Year - patientToAdd.DOB.Year;
                    if (patientToAdd.DOB.Date > today.AddYears(-age))
                        age--;
                    patientToAdd.Age = age;
                    patientToAdd.timeMinutes = TimeSpan.Parse(patientToAdd.WaitTime).TotalMinutes;
                    _patientList.Add(patientToAdd);

                }
                var complete= _patientList.OrderByDescending(e => e.timeMinutes);//sorts the list of patients according to their wait time (longest first)
                _patientList = complete.ToList();
            }
        }

        public Patients AddPatient(Patients patient)
        {//this function will be used to add a new patient to the applications list of patients
            patient.ID = _patientList.Max(e => e.ID) + 1;
            patient.timeMinutes = TimeSpan.Parse(patient.WaitTime).TotalMinutes;
            _patientList.Add(patient);
            return patient;
        }

        public IEnumerable<Patients> GetAllPatient()
        {//this function returns the list of patients to the application where needed
            return _patientList;
        }

        public Patients GetPatient(int Id)
        {//this function returns a single patient based on its id inside of 
            return _patientList.FirstOrDefault(e => e.ID == Id);
        }

        public void UpdatePatients(List<Patients> list)
        {//this function updates the applications list of patient
            _patientList = list;
        }
    }
}

