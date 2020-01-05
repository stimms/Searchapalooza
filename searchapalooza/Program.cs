using CsvHelper;
using System;
using System.IO;
using System.Linq;

namespace searchapalooza
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Building_Permits.csv"))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<BuildingPermit>().ToList();
              
            }
        }
    }
}
