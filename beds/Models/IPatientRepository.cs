//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: Interface linked to MockPatientRepository Methods
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public interface IPatientRepository
    {
        Patients GetPatient(int Id);
        IEnumerable<Patients> GetAllPatient();
        void UpdatePatients(List<Patients> list);
        Patients AddPatient(Patients patient);
    }
}
