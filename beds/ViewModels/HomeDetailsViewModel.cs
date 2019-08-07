//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: holds basic viewmodel for the application
 */

using beds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beds.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Patients Patients { get; set; }
        public string PageTitle { get; set; }
    }
}
