using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant___Assignment_4.Models
{
    public class TempStorage
    {
        private static List<AddRest> applications = new List<AddRest>();

        public static IEnumerable<AddRest> Applications => applications;

        public static void AddApplication(AddRest application)
        {
            applications.Add(application);
        }
    }
}
