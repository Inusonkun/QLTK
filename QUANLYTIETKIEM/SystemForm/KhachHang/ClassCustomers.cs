using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.KhachHang
{
    public class ClassCustomers
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get;set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public DateTime NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

    }

    public static class CustomerExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassCustomers kh)
        {
            var par = new List<KeyValuePair<string, object>>();
            par.Add(new KeyValuePair<string, object>("MaKH", kh.MaKH));
            par.Add(new KeyValuePair<string, object>("HoTen", kh.HoTen));
            par.Add(new KeyValuePair<string, object>("GioiTinh", kh.GioiTinh));
            par.Add(new KeyValuePair<string, object>("NgaySinh", kh.NgaySinh));
            par.Add(new KeyValuePair<string, object>("CMND", kh.CMND));
            par.Add(new KeyValuePair<string, object>("NgayCap", kh.NgayCap));
            par.Add(new KeyValuePair<string, object>("NoiCap", kh.NoiCap));
            par.Add(new KeyValuePair<string, object>("DiaChi", kh.DiaChi));
            par.Add(new KeyValuePair<string, object>("SoDienThoai", kh.SoDienThoai));
            par.Add(new KeyValuePair<string, object>("Email", kh.Email));
            return par;
        }

        public static string ToInsertQuery(this ClassCustomers kh)
        {
            return @"INSERT INTO DMKhachHang(MaKH, HoTen, GioiTinh, NgaySinh, CMND, NgayCap, NoiCap, DiaChi, SoDienThoai, Email) VALUES (@MaKH, @HoTen, @GioiTinh, @NgaySinh, @CMND, @NgayCap, @NoiCap, @DiaChi, @SoDienThoai, @Email)";
        }

        public static string ToUpdateQuery(this ClassCustomers kh)
        {
            return @"UPDATE DMKhachHang SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, NgayCap = @NgayCap, NoiCap = @NoiCap, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, Email = @Email WHERE MaKH = @MaKH";
        }
    }
}
