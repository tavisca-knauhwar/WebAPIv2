using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIActionResults.Models
{
    public class Person
    {
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Nationality { get; set;}
        public string Profession { get; set; }
        public string Language { get; set; }
        public BloodGroup BloodGroup { get; set; }
    }

    public enum BloodType
    {
        O,
        A,
        B,
        AB
    }

    public enum BloodTypeSign
    {
        Positive,
        Negative
    }

    public class BloodGroup
    {
        public BloodType BloodType { get; set; }
        public BloodTypeSign BloodTypeSign { get; set; }
    }


}