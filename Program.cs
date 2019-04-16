using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2359
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar0 = new Karyawan();

            kar0.Nama = "ceguk";
            kar0.Nik = "80000";
            kar0.GajiBulanan = -1000000;

            if (kar0.GajiBulanan < 0)
                kar0.GajiBulanan = 0;

            Console.WriteLine("1. " + kar0.Nik +"  "+ kar0.Nama + " \t" + kar0.GajiBulanan);

            Karyawan kar1 = new Karyawan();

            kar1.Nama = "sukentet";
            kar1.Nik = "90000";
            kar1.GajiBulanan = 1500000;

            if (kar0.GajiBulanan < 0)
                kar0.GajiBulanan = 0;

            Console.WriteLine("2. " + kar1.Nik + "  " + kar1.Nama + "\t" + kar1.GajiBulanan);


            Console.WriteLine("1. " + kar0.Nik + "  " + kar0.Nama + " \t" + kar0.GajiBulanan * 110/100 );


            Console.WriteLine("2. " + kar1.Nik + "  " + kar1.Nama + "\t" + kar1.GajiBulanan * 110/100 );
            Console.ReadKey();
        }
    }
}
