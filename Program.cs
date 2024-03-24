using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_buoi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhvien = new SinhVien();
            List<SinhVien> listSV = new List<SinhVien>();
            while (true)
            {
                Console.WriteLine("------------------menu----------------------");
                Console.WriteLine("Chon (1-9)" +
                    "\n1. Them sinh vien." +
                    "\n2. Cap nhat thong tin sinh vien." +
                    "\n3. Xoa sinh vien." +
                    "\n4. Tim kiem sinh vien." +
                    "\n5. Sap xep sinh vien theo diem trung binh GPA" +
                    "\n6. Sap xep sinh vien theo ten" +
                    "\n7. sap xep sinh vien theo ID" +
                    "\n8. Hien thi danh sach sinh vien" +
                    "\n9. Thoat");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Chon: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sinhvien.InsertSinhVien(listSV);
                        break;
                    case 2:
                        Console.Write("Nhap ID sinh vien can cap nhat: ");
                        String idUpdate = Console.ReadLine();
                        sinhvien.UpdateSinhVien(listSV, idUpdate);
                        break;
                    case 3:
                        Console.Write("Nhap ID sinh vien can xoa: ");
                        String idRemove = Console.ReadLine();
                        sinhvien.DeleteSinhVien(listSV, idRemove);
                        break;
                    case 4:
                        Console.Write("Nhap ten sinh vien can tim kiem: ");
                        String nameFind = Console.ReadLine();
                        sinhvien.UpdateSinhVien(listSV, nameFind);
                        break;
                    case 5:
                        Console.WriteLine("Danh Sach sinh vien theo diem TB: ");
                        sinhvien.SortStudentsByGPA(listSV);
                        break;
                    case 6:
                        Console.WriteLine("Danh Sach sinh vien theo diem ten: ");
                        sinhvien.SortStudentsByName(listSV);
                        break;
                    case 7:
                        Console.WriteLine("Danh Sach sinh vien theo diem ID: ");
                        sinhvien.SortStudentsByID(listSV);
                        break;
                    case 8:
                        Console.WriteLine("Danh Sach toan bo sinh vien: ");
                        sinhvien.SortStudentsByName(listSV);
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le vui long chon lai!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
