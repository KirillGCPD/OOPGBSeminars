using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task10Calculator
{
    public class ComplexNumber : ICalculable
    {
        private double _real;
        private double _imaginary;

        public double Real { get => _real; set => _real = value; }
        public double Imaginary { get => _imaginary; set => _imaginary = value; }

        public ComplexNumber(double real, double imaginary)
        {
           _real = real;
            _imaginary = imaginary;
        }
        public ComplexNumber(double real):this(real,0)
        {

        }
        public ComplexNumber():this(0,0) { }
        public ICalculable Divide(ICalculable number)
        {
            double denominator = number.Value().Real * number.Value().Real +number.Value().Imaginary * number.Value().Imaginary;
            double re = (this.Real * number.Value().Real + this.Imaginary * number.Value().Imaginary) / denominator;
            double im = (this.Imaginary * number.Value().Real - this.Real * number.Value().Imaginary) / denominator;
            return new ComplexNumber(re, im);
        }

        public ICalculable Minus(ICalculable number)
        {
            return new ComplexNumber(this.Real - number.Value().Real, this.Imaginary - number.Value().Imaginary);
        }

        public ICalculable Multiplicate(ICalculable number)
        {
            double real = this.Real * number.Value().Real - this.Imaginary * number.Value().Imaginary;
            double imag = this.Real * number.Value().Imaginary + this.Imaginary * number.Value().Real;
            return new ComplexNumber(real, imag);
        }

        public ICalculable Sum(ICalculable number)
        {
            return new ComplexNumber(this._real + number.Value().Real, this.Imaginary+number.Value().Imaginary);
        }

        public ComplexNumber Value()
        {
           return this;
        }

        public override string ToString()
        {
            if (this.Imaginary == 0) return this.Real + "";
            if (this.Real == 0) return this.Imaginary + "i";
            if (this.Imaginary < 0) return this.Real + " - " + (-this.Imaginary) + "i";
            return this.Real + " + " + this.Imaginary + "i";
        }
    }
}
