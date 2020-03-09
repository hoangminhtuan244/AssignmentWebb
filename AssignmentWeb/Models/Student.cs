using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string MaSoSV { get; set; }
        public HinhThuc HinhThuc { get; set; }
        public int SoLuong { get; set; }
        public string NgayPhat { get; set; }
        }
    public enum HinhThuc
    {
        ChongDay,
        PhatTien
    }

}