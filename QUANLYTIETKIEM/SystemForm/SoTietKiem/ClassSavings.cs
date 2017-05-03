using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.SoTietKiem
{
    public class ClassSavings
    {
        public string MaSo { get; set; }
        public string MaKH {get; set;}
        public string KyHan { get; set; }
        public float SoTienGoc { get; set; }
        public DateTime NgayMoSo { get; set; }
        public DateTime NgayDenHan { get; set; }
        public float SoDu { get; set; }
    }

    public static class SavingsExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassSavings tk)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaSo", tk.MaSo));
            parameters.Add(new KeyValuePair<string, object>("MaKH", tk.MaKH));
            parameters.Add(new KeyValuePair<string, object>("KyHan", tk.KyHan));
            parameters.Add(new KeyValuePair<string, object>("SoTienGoc", tk.SoTienGoc));
            parameters.Add(new KeyValuePair<string, object>("NgayMoSo", tk.NgayMoSo));
            parameters.Add(new KeyValuePair<string, object>("NgayDenHan", tk.NgayDenHan));
            parameters.Add(new KeyValuePair<string, object>("SoDu", tk.SoDu));

            return parameters;
        }

        public static string ToInsertQuery(this ClassSavings tk)
        {
            return @"INSERT INTO SoTietKiem(MaSo, MaKH, KyHan, SoTienGoc, NgayMoSo, NgayDenHan, SoDu) VALUES (@MaSo, @MaKH, @KyHan, @SoTienGoc, @NgayMoSo, @NgayDenHan, @SoDu)";
        }

        public static string ToUpdateQuery(this ClassSavings tk)
        {
            return @"UPDATE SoTietKiem SET MaKH = @MaKH, KyHan = @KyHan, SoTienGoc = @SoTienGoc, NgayMoSo = @NgayMoSo, NgayDenHan = @NgayDenHan, SoDu = @SoDu WHERE MaSo = @MaSo";
        }
    }
}
