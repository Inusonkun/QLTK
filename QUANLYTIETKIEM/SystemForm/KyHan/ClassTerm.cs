using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.KyHan
{
    public class ClassTerm
    {
        public string MaKyHan { get; set; }
        public string TenKyHan { get; set; }
        public string LoaiTien { get; set; }
        public float LaiSuat { get; set; }
        public string HinhThucTraLai { get; set; }
    }

    public static class TermExtension
    {
        public static List<KeyValuePair<string,object>> ToParameters(this ClassTerm kh)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaKyHan", kh.MaKyHan));
            parameters.Add(new KeyValuePair<string, object>("TenKyHan", kh.TenKyHan));
            parameters.Add(new KeyValuePair<string, object>("LoaiTien", kh.LoaiTien));
            parameters.Add(new KeyValuePair<string, object>("LaiSuat", kh.LaiSuat));
            parameters.Add(new KeyValuePair<string, object>("HinhThucTraLai", kh.HinhThucTraLai));

            return parameters;
        }

        public static string ToInsertQuery(this ClassTerm kh)
        {
            return @"INSERT INTO DMKyHan(MaKyHan, TenKyHan, LoaiTien, LaiSuat, HinhThucTraLai) VALUES (@MaKyHan, @TenKyHan, @LoaiTien, @LaiSuat, @HinhThucTraLai)";
        }

        public static string ToUpdateQuery(this ClassTerm kh)
        {
            return @"UPDATE DMKyHan SET TenKyHan = @TenKyHan, LoaiTien = @LoaiTien, LaiSuat = @LaiSuat, HinhThucTraLai = @HinhThucTraLai WHERE MaKyHan = @MaKyHan";
        }
    }
}
