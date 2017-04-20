using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTIETKIEM.SystemForm.Chinhanh
{
    public class ClassChiNhanh
    {
        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string DiaDiem { get; set; }

        public string SoDienThoai { get; set; }
        public string TruongCN { get; set; }
    }

    public static class ChiNhanExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this ClassChiNhanh cn)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaCN", cn.MaCN));
            parameters.Add(new KeyValuePair<string, object>("TenCN", cn.TenCN));
            parameters.Add(new KeyValuePair<string, object>("DiaDiem", cn.DiaDiem));
            parameters.Add(new KeyValuePair<string, object>("SoDienThoai", cn.SoDienThoai));
            parameters.Add(new KeyValuePair<string, object>("TruongCN", cn.TruongCN));

            return parameters;
        }

        public static string ToInsertQuery(this ClassChiNhanh cn)
        {
            return @"INSERT INTO ChiNhanh(MaCN, TenCN, DiaDiem, SoDienThoai, TruongCN) VALUES (@MaCN, @TenCN, @DiaDiem, @SoDienThoai, @TruongCN)";
        }

        public static string ToUpdateQuery(this ClassChiNhanh cn)
        {
            return @"UPDATE ChiNhanh SET MaCN = @MaCN, TenCN = @TenCN, DiaDiem = @DiaDiem, SoDienThoai = @SoDienThoai, TruongCN = @TruongCN";
        }
    }
}
