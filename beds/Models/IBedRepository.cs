//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: Interface linked to MockBedRepository methods
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public interface IBedRepository
    {
        IEnumerable<Beds> GetAllBeds();
    }
}
