using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_buoi6
{
    public interface ISinhVien
    {
        void GetAllSinhVien(List<SinhVien> ListSV);
        void GetSinhVien(List<SinhVien> ListSV, String id);
        void InsertSinhVien(List<SinhVien> ListSV); 
        void DeleteSinhVien(List<SinhVien> ListSV, String id);
        void UpdateSinhVien(List<SinhVien> ListSV, String id);
        void SortStudentsByGPA(List<SinhVien> ListSV);
        void SortStudentsByName(List<SinhVien> ListSV);
        void SortStudentsByID(List<SinhVien> ListSV);

    }
}
