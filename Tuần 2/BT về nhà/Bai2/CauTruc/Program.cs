using System;

namespace CauTruc
{
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh[] hs = new HocSinh[5];
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Nhap vao thong tin cua hoc sinh thu {0}", i + 1);
                Console.Write("\tHo ten: ");
                hs[i].HoTen = Console.ReadLine();
                Console.Write("\tTuoi: ");
                hs[i].Tuoi = int.Parse(Console.ReadLine());
                Console.Write("\tGioi tinh: ");
                if (Console.ReadLine() == "true") hs[i].GioiTinh = true;
                else hs[i].GioiTinh = false;
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += hs[i].Tuoi;
            }
            Console.WriteLine($"Tong so tuoi cua cac hoc sinh la: {sum}");
        }
        struct HocSinh
        {
            public string HoTen;
            public int Tuoi;
            public Boolean GioiTinh;
        }
    }
}
