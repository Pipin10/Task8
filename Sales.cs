using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_8
{
    class Sales : Karyawan
    {
        public double JmlPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JmlPenjualan * Komisi;
        }
    }
}
