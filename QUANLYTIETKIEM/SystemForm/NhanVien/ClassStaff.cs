using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.NhanVien
{
    public class ClassStaff
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayCongTac { get; set; }
        public string ChucVu { get; set; }
        public string ChiNhanh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string TinhTrang { get; set; }
    }

    public static class NhanVienExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassStaff nv)
        {
            var paramaters = new List<KeyValuePair<string, object>>();
            paramaters.Add(new KeyValuePair<string, object>("MaNV", nv.MaNV));
            paramaters.Add(new KeyValuePair<string, object>("HoTen", nv.HoTen));
            paramaters.Add(new KeyValuePair<string, object>("GioiTinh", nv.GioiTinh));
            paramaters.Add(new KeyValuePair<string, object>("NgaySinh", nv.NgaySinh));
            paramaters.Add(new KeyValuePair<string, object>("NgayCongTac", nv.NgayCongTac));
            paramaters.Add(new KeyValuePair<string, object>("ChucVu", nv.ChucVu));
            paramaters.Add(new KeyValuePair<string, object>("ChiNhanh", nv.ChiNhanh));
            paramaters.Add(new KeyValuePair<string, object>("SoDienThoai", nv.SoDienThoai));
            paramaters.Add(new KeyValuePair<string, object>("Email", nv.Email));
            paramaters.Add(new KeyValuePair<string, object>("DiaChi", nv.DiaChi));
            paramaters.Add(new KeyValuePair<string, object>("TinhTrang", nv.TinhTrang));

            return paramaters;
        }

        public static string ToInsertQuery(this ClassStaff nv)
        {
            return @"INSERT INTO NhanVien(MaNV, HoTen, GioiTinh, NgaySinh, NgayCongTac, ChucVu, ChiNhanh, SoDienThoai, Email, DiaChi, TinhTrang) VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @NgayCongTac, @ChucVu, @ChiNhanh, @SoDienThoai, @Email, @DiaChi, @TinhTrang)";
        }

        public static string ToUpdateQuery(this ClassStaff nv)
        {
            return @"UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NgayCongTac = @NgayCongTac, ChucVu = @ChucVu, ChiNhanh = @ChiNhanh, SoDienThoai = @SoDienThoai, Email = @Email, DiaChi = @DiaChi, TinhTrang = @TinhTrang WHERE MaNV = @MaNV";

            //Update thiếu where 2012
            //1 điều nữa! Nên xài sql 2014 trở lên, nó có cái tool sql profile, có thể track đc sql query, làm rất là khỏe
        }
    }
}
