using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    internal class Checker
    {
        public ICollection<BasePackage> AvailablePackages { get; private set; }

        public Checker()
        {
            AvailablePackages = new List<BasePackage>();
        }

        private Func<BasePackage, decimal> filter = x => x.Cost;

        public IPackage GetAppropriatePackage(int length, int height, int breadth, float weight, out string errorMessage)
        {
            errorMessage = string.Empty;
            foreach (var package in AvailablePackages.OrderBy(filter))
            {
                if (package.CheckSize(length, height, breadth)) {
                    if (package.CheckWeight(weight))
                    {
                        return package as IPackage;
                    }
                    else {

                        //Handle overweight here
                        errorMessage = "Overweight.";
                        return null;
                    }
                }
            }
            errorMessage = "Package not found.";
            return null;
        }

        
        
    }
}