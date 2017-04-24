using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.GiaoDich
{
    public class ClassTransaction
    {
        public int SoGiaoDich { get; set; }
        public string NhanVien { get; set; }
        public string KhachHang { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public string SoGD { get; set; }
        public float SoTienGD { get; set; }
        public string SoButToan { get; set; }
        public string TinhChat { get; set; }
    }

    public static class TransactionExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassTransaction gd)
        {
            var par = new List<KeyValuePair<string, object>>();
            par.Add(new KeyValuePair<string, object>("SoGiaoDich", gd.SoGiaoDich));
            par.Add(new KeyValuePair<string, object>("NhanVien", gd.NhanVien));
            par.Add(new KeyValuePair<string, object>("KhachHang", gd.KhachHang));
            par.Add(new KeyValuePair<string, object>("NgayGiaoDich", gd.NgayGiaoDich));
            par.Add(new KeyValuePair<string, object>("SoGD", gd.SoGD));
            par.Add(new KeyValuePair<string, object>("SoTienGD", gd.SoTienGD));
            par.Add(new KeyValuePair<string, object>("SoButToan", gd.SoButToan));
            par.Add(new KeyValuePair<string, object>("TinhChat", gd.TinhChat));

            return par;
        }

        public static string ToInsertQuery(this ClassTransaction gd)
        {
            return @"INSERT INTO Giao_Dich(SoGiaoDich, NhanVien, KhachHang, NgayGiaoDich, SoGD, SoTienGD, SoButToan, TinhChat) VALUES (@SoGiaoDich, @NhanVien, @KhachHang, @NgayGiaoDich, @SoGD, @SoTienGD, @SoButToan, @TinhChat)";
        }

        public static string ToUpdate(this ClassTransaction gd)
        {
            return @"UPDATE Giao_Dich SET NhanVien = @NhanVien, KhachHang = @KhachHang, NgayGiaoDich = @NgayGiaoDich, SoGD = @SoGD, SoTienGD = @SoTienGD, SoButToan = @SoButToan, TinhChat = @TinhChat WHERE SoGiaoDich = @SoGiaoDich";
        }
    }
}
