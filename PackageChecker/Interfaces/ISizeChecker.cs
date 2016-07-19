using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    internal interface ISizeChecker
    {
        bool CheckSize(int length, int height, int breadth);
    }
}