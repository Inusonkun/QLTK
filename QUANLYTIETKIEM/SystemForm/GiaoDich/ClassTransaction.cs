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
        public string SoTK { get; set; }
        public DateTime NgayGiaoDich { get; set; }        
        public float SoTienGD { get; set; }
        public string TinhChat { get; set; }
        public float SoTienConLai { get; set; }
    }

    public static class TransactionExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassTransaction gd)
        {
            var par = new List<KeyValuePair<string, object>>();
            par.Add(new KeyValuePair<string, object>("SoGiaoDich", gd.SoGiaoDich));
            par.Add(new KeyValuePair<string, object>("NhanVien", gd.NhanVien));
            par.Add(new KeyValuePair<string, object>("SoTK", gd.SoTK));
            par.Add(new KeyValuePair<string, object>("NgayGiaoDich", gd.NgayGiaoDich));
            par.Add(new KeyValuePair<string, object>("SoTienGD", gd.SoTienGD));
            par.Add(new KeyValuePair<string, object>("TinhChat", gd.TinhChat));
            par.Add(new KeyValuePair<string, object>("SoTienConLai", gd.SoTienConLai));

            return par;
        }

        public static string ToInsertQuery(this ClassTransaction gd)
        {
            return @"INSERT INTO Giao_Dich(SoGiaoDich, NhanVien, SoTK, NgayGiaoDich, SoTienGD, TinhChat, SoTienConLai) VALUES (@SoGiaoDich, @NhanVien, @SoTK, @NgayGiaoDich, @SoTienGD, @TinhChat, @SoTienConLai)";
        }

        public static string ToUpdateQuery(this ClassTransaction gd)
        {
            return @"UPDATE Giao_Dich SET NhanVien = @NhanVien, SoTK = @SoTK, NgayGiaoDich = @NgayGiaoDich, SoTienGD = @SoTienGD, TinhChat = @TinhChat, SoTienConLai = @SoTienConLai WHERE SoGiaoDich = @SoGiaoDich";
        }
    }
}
