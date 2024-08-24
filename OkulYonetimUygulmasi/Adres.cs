using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class Adres
    {
        Adres(string il, string ilce, string mahalle)
        {
            Il = il;
            Ilce = ilce;
            Mahalle = mahalle;
        }
        public string Il;
        public string Ilce;
        public string Mahalle { get; set; }
    }

}
