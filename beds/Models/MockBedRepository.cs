//Author: Ryan French Date Complete: 2019/08/06
/*Purpose: Contains the method definitions for the IBedRepository Interface
 */
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace beds.Models
{
    public class MockBedRepository : IBedRepository
    {
        List<Beds> _bedList = new List<Beds>();

        public MockBedRepository()
        {

            var reader = new StreamReader("wwwroot/Beds.csv");
            var csv = new CsvReader(reader);
            var listOfBeds = csv.GetRecords<Beds>();

            foreach (var p in listOfBeds)
            {
                Beds bedToAdd = new Beds();
                bedToAdd.ID = p.ID;
                bedToAdd.Name = p.Name;

                _bedList.Add(bedToAdd);


            }
        }

        public IEnumerable<Beds> GetAllBeds()
        {
            return _bedList;
        }

    }
}
