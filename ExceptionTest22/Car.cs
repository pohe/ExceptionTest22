using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest22
{
    public class Car
    {
        public string Regnr { get; set; }
        public string Model { get; set; }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Car(string regnr, string model, int year)
        {
            if (regnr.Length != 8)
                throw new ArgumentException("Regnr skal være 8 karakterer lang");
            Regnr = regnr;
            Model = model;
            _year = year;
        }

    }
}
