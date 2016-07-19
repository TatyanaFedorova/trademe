using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageChecker
{
    internal abstract class BasePackage : IPackage, ISizeChecker, IWeightChecker
    {
        public abstract int Breadth { get; }
        public abstract decimal Cost { get; }
        public abstract string Description { get; }
        public abstract int Height { get; }
        public abstract int Length { get; }
        public abstract string Name { get; }
        public abstract float Weight { get; }

        public virtual bool CheckSize(int length, int height, int breadth)
        {
            return this.Length >= length && this.Height >= height && this.Breadth >= breadth;
        }
        public virtual bool CheckWeight(float weight)
        {
            return this.Weight >= weight;
        }
    }
}