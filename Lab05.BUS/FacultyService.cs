using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            QuanLySinhVienDB context = new QuanLySinhVienDB();
            return context.Faculties.ToList();
        }
    }
}
