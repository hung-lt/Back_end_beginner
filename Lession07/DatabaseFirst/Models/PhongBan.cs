using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string MaPhong { get; set; } = null!;
        public string TenPhong { get; set; } = null!;
        public string? DienThoai { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
