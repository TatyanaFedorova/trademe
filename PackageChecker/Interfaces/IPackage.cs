using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    public interface IPackage
    {
        string Name { get; }
        string Description { get; }
        int Length { get; }
        int Height { get; }
        int Breadth { get; }
        float Weight { get; }
        decimal Cost { get; }
    }
}