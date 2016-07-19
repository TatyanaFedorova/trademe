using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageChecker;

namespace ProductionEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new PackageChecker.PackageChecker();
            string errormessage;
            var res = checker.CheckPackage(200, 100, 200, 4, out errormessage);
            PrintResult(res, errormessage);
            res = checker.CheckPackage(200, 100, 200, 50, out errormessage);
            PrintResult(res, errormessage);
            res = checker.CheckPackage(220, 100, 200, 25, out errormessage);
            PrintResult(res, errormessage);
            res = checker.CheckPackage(290, 100, 200, 10, out errormessage);
            PrintResult(res, errormessage);
            res = checker.CheckPackage(400, 100, 200, 10, out errormessage);
            PrintResult(res, errormessage);


            Console.ReadLine();
        }
        private static void PrintResult(IPackage package, string error)
        {
            if (package != null)
            {
                Console.WriteLine(string.Format("Name: {0}, Cost{1}", package.Name, package.Cost));
            }
            else {
                Console.WriteLine(error);
            }
        }
    }
}
