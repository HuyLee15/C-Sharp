using System;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ho ten cua hoc sinh: ");
            string hoTen = Console.ReadLine();
            hoTen = hoTen.ToUpper();
            Console.Write("Nhap diem cua hoc sinh: ");
            float diem = float.Parse(Console.ReadLine());
            if (diem > 10 || diem < 0) Console.Write("Diem khong hop le");
            else
            {
                if (diem >= 8) Console.Write($"{hoTen} xep loai gioi");
                else if(diem>=6.5) Console.Write($"{hoTen} xep loai kha");
                else if (diem >= 5) Console.Write($"{hoTen} xep loai trung binh");
                else Console.Write($"{hoTen} xep loai trung yeu");
            }
        }
    }
}
