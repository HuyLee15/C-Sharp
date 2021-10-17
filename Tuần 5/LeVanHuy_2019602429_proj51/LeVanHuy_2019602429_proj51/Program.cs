using System;
using System.Collections.Generic;

namespace LeVanHuy_2019602429_proj51
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ThisinhA> thisinh = new List<ThisinhA>();
            string luachon = "";
            while(luachon != "6")
            {
                Console.Write("\nNhan 6 de ket thuc chuong trinh: ");
                luachon = Console.ReadLine();
                if (luachon == "1") thisinh.Add(nhap());
                else if (luachon == "2")
                {
                    if (thisinh.Count == 0) Console.WriteLine("Danh sach chua co thi sinh!");
                    else xuat(thisinh);
                }
                else if (luachon == "3")
                {
                    if (thisinh.Count == 0) Console.WriteLine("Danh sach chua co thi sinh!");
                    else xuatDiem(thisinh);
                }
                else if (luachon == "4")
                {
                    if (thisinh.Count == 0) Console.WriteLine("Danh sach chua co thi sinh!");
                    else xuatDiaChi(thisinh);
                }
                else if (luachon == "5")
                {
                    if (thisinh.Count == 0) Console.WriteLine("Danh sach chua co thi sinh!");
                    else xuatSoBD(thisinh);
                }
                else if(luachon != "6") Console.WriteLine("Nhap khong dung dinh dang!");
            }
        }

        private static ThisinhA nhap()
        {
            ThisinhA ts = new ThisinhA();
            Console.Write("Nhap vao so bao danh: ");
            ts.SoBD = Console.ReadLine();
            Console.Write("Nhap vao ho ten: ");
            ts.HoTen = Console.ReadLine();
            Console.Write("Nhap vao dia chi: ");
            ts.DiaCHi = Console.ReadLine();
            Console.Write("Nhap vao diem toan: ");
            ts.DiemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao diem ly: ");
            ts.DiemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao diem hoa: ");
            ts.DiemHoa = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao diem uu tien: ");
            ts.DiemUuTien = float.Parse(Console.ReadLine());
            ts.DiemTong = ts.DiemHoa + ts.DiemUuTien + ts.DiemLy + ts.DiemToan;
            return ts;            
        }
        private static void xuat(List<ThisinhA> thisinh)
        {

            foreach (ThisinhA item in thisinh)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", item.SoBD, item.HoTen, item.DiaCHi, item.DiemToan, item.DiemLy, item.DiemHoa, item.DiemUuTien, item.DiemTong);
            }
        }
        private static void xuatDiem(List<ThisinhA> thisinh)
        {
            Console.Write("Nhap vao diem tong: ");
            float diem = float.Parse(Console.ReadLine());
            foreach(ThisinhA item in thisinh)
            {
                if (item.DiemTong >= diem) Console.Write($"\t{item.HoTen}");
            }
        }
        private static void xuatDiaChi(List<ThisinhA> thisinh)
        {
            Console.Write("Nhap vao dia chi: ");
            string diachi = (Console.ReadLine());
            foreach (ThisinhA item in thisinh)
            {
                if (item.DiaCHi == diachi) Console.Write($"\t{item.HoTen}");
            }
        }
        private static void xuatSoBD(List<ThisinhA> thisinh)
        {
            Console.Write("Nhap vao so bao danh: ");
            string sbd = Console.ReadLine();
            foreach (ThisinhA item in thisinh)
            {
                if(item.SoBD == sbd) Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", item.SoBD, item.HoTen, item.DiaCHi, item.DiemToan, item.DiemLy, item.DiemHoa, item.DiemUuTien, item.DiemTong);

            }
        }
    }
}
