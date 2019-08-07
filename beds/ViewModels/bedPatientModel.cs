//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: This class is used in order to pass IEnumerable<beds> and IEnumerable<Patients> into manager.cshtml using a dynamic model
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public class bedPatientModel
    {
        public IEnumerable<Beds> _beds { get; set; }
        public IEnumerable<Patients> _patient { get; set; }
    }
}
