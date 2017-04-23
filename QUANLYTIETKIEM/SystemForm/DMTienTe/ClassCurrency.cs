using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.DMTienTe
{
    public class ClassCurrency
    {
        public string MaTien { get; set; }
        public string TenLoaiTien { get; set; }
        public float TyGia { get; set; }
    }

    public static class CurrencyExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassCurrency tt)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaTien", tt.MaTien));
            parameters.Add(new KeyValuePair<string, object>("TenLoaiTien", tt.TenLoaiTien));
            parameters.Add(new KeyValuePair<string, object>("TyGia", tt.TyGia));
            return parameters;
        }

        public static string ToInsertQuery(this ClassCurrency tt)
        {
            return @"INSERT INTO LoaiTien(MaTien, TenLoaiTien, TyGia) VALUES (@MaTien, @TenLoaiTien, @TyGia)";
        }

        public static string ToUpdateQuery(this ClassCurrency tt)
        {
            return @"UPDATE LoaiTien SET  TenLoaiTien = @TenLoaiTien, TyGia = @TyGia WHERE MaTien = @MaTien";
        }
    }
}
