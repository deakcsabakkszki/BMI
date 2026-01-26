using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{/*
  Név;Életkor;Magasság;Testsúly
Kiss Péter;16;175;68
  */
    public class Diak
    {
        public String Név {  get; set; }
        public int Életkor {  get; set; }
        public int Magasság {  get; set; }
        public int Testsúly {  get; set; }

        public Diak(string név, int életkor, int magasság, int testsúly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Testsúly = testsúly;
        }

        public override string? ToString()
        {
            return $"{Név} {Életkor}éves {Magasság}cm {Testsúly}kg";
        }
        public string bmi()
        {
            double magassagm = Magasság / 100.0;
            double BMI = Testsúly / (magassagm * magassagm);
            if (BMI < 18.5)
                return "Sovány";
            else if (BMI < 25)
                return "Normal";
            else return "egyéb";
        }
       
        
    }
}
