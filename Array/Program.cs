using System;
using System.Linq;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeject Declaration
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.Nama = "Kelly";
            mhs1.Nilai = 95;

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.Nama = "Bill";
            mhs2.Nilai = 80;

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "1236";
            mhs3.Nama = "Saito";
            mhs3.Nilai = 92;

            //Mahasiswa Array Object Declaration
            Mahasiswa[] arrMahasiswa = new Mahasiswa[3];

            arrMahasiswa[0] = mhs1;
            arrMahasiswa[1] = mhs2;
            arrMahasiswa[2] = mhs3;

            Console.WriteLine("No. Nim        Nama          Nilai");
            Console.WriteLine("----------------------------------");
            
            for(int i=0; i<arrMahasiswa.Length; i++)
            {
                Mahasiswa mhs = arrMahasiswa[i];
                Console.WriteLine("{0}.  {1}        {2}         {3}", i+1, mhs.Nim, mhs.Nama, mhs.Nilai);
            }

            Console.ReadKey();
        }
    }
}

