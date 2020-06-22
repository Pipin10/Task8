using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_8
{
    class KaryawanDaily : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
