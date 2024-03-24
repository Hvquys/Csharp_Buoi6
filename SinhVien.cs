using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_buoi6
{
    public class SinhVien : ISinhVien
    {
        private String id { get; set; }
        private string ten { get; set; }
        private string gioiTinh { get; set; }
        private int tuoi {  get; set; }
        private float diemToan { get; set; }
        private float diemLy { get; set; }
        private float diemHoa { get; set; }
        private float diemTB { get; set; }
        private String hocLuc { get; set; }

        public SinhVien() { }

        public SinhVien(String id, string ten, string gioiTinh, int tuoi, float diemToan, float diemLy, float diemHoa, float diemTB, String hocLuc)
        {
            this.id = id;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
            this.diemTB = diemTB;
            this.hocLuc = hocLuc;
        }

        public void GetAllSinhVien(List<SinhVien> ListSV)
        {
            try
            {
                if (ListSV != null)
                {
                    Console.WriteLine("--------------\n" +
                        "id \t ten \t gioitinh \t tuoi \t diemtoan \t diemly \t diemHoa \t diemTB \t HocLuc " +
                        "\n--------------\n");
                    foreach (var item in ListSV)
                    {
                        Console.WriteLine(
                            "\n" + item.id +
                            "\t" + item.ten +
                            "\t" + item.gioiTinh +
                            "\t" + item.tuoi +
                            "\t" + item.diemToan +
                            "\t" + item.diemLy +
                            "\t" + item.diemHoa +
                            "\t" + item.diemTB +
                            "\t" + item.hocLuc +
                            "\n---------------");
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void GetSinhVien(List<SinhVien> ListSV, String ten)
        {
            var sinhVien = new SinhVien();
            foreach (var item in ListSV)
            {
                if (item.ten == ten)
                {
                    sinhVien.id = item.id;
                    sinhVien.ten = item.ten;
                    sinhVien.gioiTinh = item.gioiTinh;
                    sinhVien.tuoi = item.tuoi;
                    sinhVien.diemToan = item.diemToan;
                    sinhVien.diemLy = item.diemLy;
                    sinhVien.diemHoa = item.diemHoa;
                    sinhVien.diemTB = item.diemTB;
                    sinhVien.hocLuc = item.hocLuc;
                    break;
                }
            }
            if(sinhVien != null)
            {
                Console.WriteLine("----------------" +
                                "\n" + sinhVien.id +
                                "\n" + sinhVien.ten +
                                "\n" + sinhVien.gioiTinh +
                                "\n" + sinhVien.tuoi +
                                "\n" + sinhVien.diemToan +
                                "\n" + sinhVien.diemLy +
                                "\n" + sinhVien.diemHoa +
                                "\n" + sinhVien.diemTB +
                                "\n" + sinhVien.hocLuc +
                                "\n---------------");
            }
        }

        public void InsertSinhVien(List<SinhVien> ListSV)
        {
            Console.WriteLine("Them sinh vien:");
            String id = Guid.NewGuid().ToString();
            Console.WriteLine("id :" + id);
            Console.Write("ten sinh vien: ");
            String inputTen = Console.ReadLine();
            Console.Write("gioi tinh sinh vien: ");
            String inputGioiTinh = Console.ReadLine();
            int tuoi = 0;
            bool isInt = false;
            while (!isInt)
            {
                Console.Write("tuoi sinh vien: ");
                String inputTuoi = Console.ReadLine();
                if (NewLibs.CheckValueInput.CheckIsInt(inputTuoi))
                {
                    tuoi = int.Parse(inputTuoi);
                    if (0 < tuoi && tuoi <= 80)
                    {
                        isInt = true;
                    }
                    else
                    {
                        Console.WriteLine("Tuoi khong hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Tuoi khong hop le");
                }
            }
            float diemToan = 0;
            bool isFloat = false;
            while (!isFloat)
            {
                Console.Write("diem toan: ");
                String inputDiemToan = Console.ReadLine();
                if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemToan))
                {
                    diemToan = float.Parse(inputDiemToan);
                    if (0 <= diemToan && diemToan <= 10)
                    {
                        isFloat = true;
                    }
                    else
                    {
                        Console.WriteLine("Diem toan khong hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Diem toan khong hop le");
                }
            }
            float diemLy = 0;
            isFloat = false;
            while (!isFloat)
            {
                Console.Write("Diem ly: ");
                String inputDiemLy = Console.ReadLine();
                if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemLy))
                {
                    diemLy = float.Parse(inputDiemLy);
                    if (0 <= diemLy && diemLy <= 10)
                    {
                        isFloat = true;
                    }
                    else
                    {
                        Console.WriteLine("Diem ly khong hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Diem ly khong hop le");
                }
            }
            float diemHoa = 0;
            isFloat = false;
            while (!isFloat)
            {
                Console.Write("Diem hoa: ");
                String inputDiemHoa = Console.ReadLine();
                if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemHoa))
                {
                    diemHoa = float.Parse(inputDiemHoa);
                    if (0 <= diemHoa && diemHoa <= 10)
                    {
                        isFloat = true;
                    }
                    else
                    {
                        Console.WriteLine("Diem hoa khong hop le");
                    }
                }
                else
                {
                    Console.WriteLine("Diem hoa khong hop le");
                }
            }

            float diemTB = (diemToan + diemLy + diemHoa) / 3;
            Console.WriteLine("Diem TB: " + diemTB);

            String hocLuc;
            if (diemTB >= 8)
                hocLuc = "Gioi";
            else if (diemTB >= 6.5)
                hocLuc = "Kha";
            else if (diemTB >= 5)
                hocLuc = "Trung Binh";
            else
                hocLuc = "Yeu";
            Console.WriteLine("Hoc luc: " + hocLuc);

            SinhVien sinhVien = new SinhVien(id, inputTen, inputGioiTinh, tuoi, diemToan, diemLy, diemHoa, diemTB, hocLuc);

            ListSV.Add(sinhVien);
            GetAllSinhVien(ListSV);

        }

        public void DeleteSinhVien(List<SinhVien> ListSV, String id)
        {
            SinhVien sinhVien = new SinhVien();
            if (ListSV != null)
            {
                foreach (SinhVien sv in ListSV)
                {
                    if (sv.id == id)
                    {
                        sinhVien.id = sv.id;
                        sinhVien.ten = sv.ten;
                        sinhVien.gioiTinh = sv.gioiTinh;
                        sinhVien.tuoi = sv.tuoi;
                        sinhVien.diemToan = sv.diemToan;
                        sinhVien.diemLy = sv.diemLy;
                        sinhVien.diemHoa = sv.diemHoa;
                        sinhVien.diemTB = sv.diemTB;
                        sinhVien.hocLuc = sv.hocLuc;

                        break;
                    }
                }
                if (sinhVien != null)
                {
                    ListSV.Remove(sinhVien);
                    GetAllSinhVien(ListSV);
                }

            }
        }

        public void UpdateSinhVien(List<SinhVien> ListSV, String id)
        {
            SinhVien sinhVien = new SinhVien();
            if (ListSV != null)
            {
                foreach (SinhVien sv in ListSV)
                {
                    if (sv.id == id)
                    {
                        Console.WriteLine("Cap nhat thong tin sinh vien:" +
                            "\n ID Sinh Vien: " + sv.id);
                        Console.Write("ten sinh vien: ");
                        sv.ten = Console.ReadLine();
                        Console.Write("gioi tinh sinh vien: ");
                        sv.gioiTinh = Console.ReadLine();
                        Console.Write("tuoi sinh vien: ");
                        int tuoi = 0;
                        bool isInt = false;
                        while (!isInt)
                        {
                            Console.Write("tuoi sinh vien: ");
                            String inputTuoi = Console.ReadLine();
                            if (NewLibs.CheckValueInput.CheckIsInt(inputTuoi))
                            {
                                tuoi = int.Parse(inputTuoi);
                                if (0 < tuoi && tuoi <= 80)
                                {
                                    isInt = true;
                                }
                                else
                                {
                                    Console.WriteLine("Tuoi khong hop le");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Tuoi khong hop le");
                            }
                        }
                        Console.Write("diem toan: ");
                        float diemToan = 0;
                        bool isFloat = false;
                        while (!isFloat)
                        {
                            String inputDiemToan = Console.ReadLine();
                            if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemToan))
                            {
                                diemToan = float.Parse(inputDiemToan);
                                if (0 <= diemToan && diemToan <= 10)
                                {
                                    isFloat = true;
                                }
                                else
                                {
                                    Console.WriteLine("Diem toan khong hop le");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Diem toan khong hop le");
                            }
                        }
                        Console.Write("Diem ly: ");
                        float diemLy = 0;
                        isFloat = false;
                        while (!isFloat)
                        {
                            String inputDiemLy = Console.ReadLine();
                            if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemLy))
                            {
                                diemLy = float.Parse(inputDiemLy);
                                if (0 <= diemLy && diemLy <= 10)
                                {
                                    isFloat = true;
                                }
                                else
                                {
                                    Console.WriteLine("Diem ly khong hop le");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Diem ly khong hop le");
                            }
                        }
                        Console.Write("Diem hoa: ");
                        float diemHoa = 0;
                        isFloat = false;
                        while (!isFloat)
                        {
                            String inputDiemHoa = Console.ReadLine();
                            if (NewLibs.CheckValueInput.CheckIsFloat(inputDiemHoa))
                            {
                                diemHoa = float.Parse(inputDiemHoa);
                                if (0 <= diemHoa && diemHoa <= 10)
                                {
                                    isFloat = true;
                                }
                                else
                                {
                                    Console.WriteLine("Diem hoa khong hop le");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Diem hoa khong hop le");
                            }
                        }

                        sv.diemToan = diemToan;
                        sv.diemLy = diemLy;
                        sv.diemHoa = diemHoa;
                        sv.diemTB = (sv.diemToan + sv.diemLy + sv.diemHoa) / 3;
                        Console.WriteLine("Diem TB: " + sv.diemTB);
                        if (sv.diemTB >= 8)
                            sv.hocLuc = "Gioi";
                        else if (sv.diemTB >= 6.5)
                            sv.hocLuc = "Kha";
                        else if (sv.diemTB >= 5)
                            sv.hocLuc = "Trung Binh";
                        else
                            sv.hocLuc = "Yeu";
                        Console.WriteLine("Hoc luc: " + sv.hocLuc);

                        GetAllSinhVien(ListSV);
                        break;
                    }
                }

                
            }
        }

        public void SortStudentsByName(List<SinhVien> ListSV)
        {
            // Sắp xếp danh sách sinh viên theo tên (tăng dần)
            var sortedStudentsByName = ListSV.OrderBy(student => student.ten);

            // In danh sách sinh viên đã sắp xếp theo tên
            foreach (var item in sortedStudentsByName)
            {
                Console.WriteLine("----------------" +
                            "\n" + item.id +
                            "\t" + item.ten +
                            "\t" + item.gioiTinh +
                            "\t" + item.tuoi +
                            "\t" + item.diemToan +
                            "\t" + item.diemLy +
                            "\t" + item.diemHoa +
                            "\t" + item.diemTB +
                            "\t" + item.hocLuc +
                            "\n---------------");
            }
        }

        public void SortStudentsByID(List<SinhVien> ListSV)
        {
            var sortStudentsByID = ListSV.OrderBy(student => student.id);
            foreach (var item in sortStudentsByID)
            {
                Console.WriteLine("----------------" +
                            "\n" + item.id +
                            "\t" + item.ten +
                            "\t" + item.gioiTinh +
                            "\t" + item.tuoi +
                            "\t" + item.diemToan +
                            "\t" + item.diemLy +
                            "\t" + item.diemHoa +
                            "\t" + item.diemTB +
                            "\t" + item.hocLuc +
                            "\n---------------");
            }
        }

        public void SortStudentsByGPA(List<SinhVien> ListSV)
        {
            var sortStudentsByGPA = ListSV.OrderBy(student => student.diemTB);
            foreach (var item in sortStudentsByGPA)
            {
                Console.WriteLine("----------------" +
                            "\n" + item.id +
                            "\t" + item.ten +
                            "\t" + item.gioiTinh +
                            "\t" + item.tuoi +
                            "\t" + item.diemToan +
                            "\t" + item.diemLy +
                            "\t" + item.diemHoa +
                            "\t" + item.diemTB +
                            "\t" + item.hocLuc +
                            "\n---------------");
            }
        }
    }
}
