using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanReg karyawanReg = new KaryawanReg();
            karyawanReg.Nik = "123-234-345";
            karyawanReg.Nama = "Markonah Suyamali";
            karyawanReg.GajiBulanan = 4000000;

            KaryawanDaily karyawanDaily = new KaryawanDaily();
            karyawanDaily.Nik = "123-321-346";
            karyawanDaily.Nama = "Jeffri Jae";
            karyawanDaily.JumlahJamKerja = 8;
            karyawanDaily.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "123-333-347";
            sales.Nama = "Johno Seo";
            sales.JmlPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanReg);
            listKaryawan.Add(karyawanDaily);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
