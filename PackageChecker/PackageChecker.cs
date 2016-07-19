using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    public sealed class PackageChecker
    {
        private readonly Checker _checker;
        public PackageChecker()
        {
            _checker = new Checker();
            _checker.AvailablePackages.Add(new Package("Small Package", 210, 130, 280, 25.0f, 5, null));
            _checker.AvailablePackages.Add(new Package("Medium Package", 280, 180, 390, 25.0f, 7.50m, null));
            _checker.AvailablePackages.Add(new Package("Large Package", 380, 200, 550, 25.0f, 8.50m, null));

        }
        public IPackage CheckPackage(int length, int height, int breadth, float weight, out string errorMessage)
        {
            return _checker.GetAppropriatePackage(length, height, breadth, weight, out errorMessage);
        }
    }
}
