using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulmasi
{
    internal class DersNotu
    {
        public string DersAdi;
        public int Not;

        /// <summary>
        /// Bu constructure yapısı DersNotu clasının paramaetleriyle yeni bir nesne oluşturulmasını sağlar.
        /// </summary>
        /// <param name="dersAdi"></param>
        /// <param name="not"></param>
        public DersNotu(string dersAdi, int not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }               
    }
}
