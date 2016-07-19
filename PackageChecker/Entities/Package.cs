using PackageChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    internal class Package : BasePackage
    {
        private readonly int _breadth;
        private readonly decimal _cost;
        private readonly string _description;
        private readonly int _height;
        private readonly int _length;
        private readonly string _name;
        private readonly float _weight;

        public Package(string name, int length, int height, int breadth, float weight, decimal cost, string description = null)
        {
            _name = name;
            _length = length;
            _height = height;
            _breadth = breadth;
            _weight = weight;
            _cost = cost;
            _description = description;
        }

        public override int Breadth
        {
            get
            {
                return _breadth;
            }
        }

        public override decimal Cost
        {
            get
            {
                return _cost;
            }
        }

        public override string Description
        {
            get
            {
                return _description;
            }
        }

        public override int Height
        {
            get
            {
                return _height;
            }
        }

        public override int Length
        {
            get
            {
                return _length;
            }
        }

        public override string Name
        {
            get
            {
                return _name;
            }
        }

        public override float Weight
        {
            get
            {
                return _weight;
            }
        }

    }
}