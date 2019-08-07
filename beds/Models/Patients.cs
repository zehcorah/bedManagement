//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: holds 2 classes, patientInput is used to take inputs from the csv files
 * where as Patients is used to hold data during runtime
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public class PatientInput
    {
        public string ID {get; set;}
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string WaitTime { get; set; }
        public string Location { get; set; }
    }

    public class Patients
    {

        public int ID { get; set; }

        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [RegularExpression(@"(?:[01]\d|2[0123]):(?:[012345]\d)", ErrorMessage ="use the format 99:59, ensuring the minutes are not 60+")]
        [Required]
        public string WaitTime { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public double timeMinutes { get; set; }

    }
}
