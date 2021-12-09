using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\

        public Complex(double realPart, double imaginaryPart)
        {
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }
        
        public double RealPart { get; }
        public double ImaginaryPart { get; }

        public override bool Equals(object obj)
        {
            return obj is Complex complex &&
                   RealPart == complex.RealPart &&
                   ImaginaryPart == complex.ImaginaryPart;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RealPart, ImaginaryPart);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}