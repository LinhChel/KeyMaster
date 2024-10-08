using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class GioHang
    {
        [Key]
        public Guid IdGioHang { get; set; }

        [MaxLength(50)] // Giới hạn độ dài của TrangThai tối đa là 50 ký tự
        public string? TrangThai { get; set; }

        public DateTime? NgayTao { get; set; }

        [Required] // Đảm bảo rằng IdNguoiDung luôn được cung cấp
        public Guid IdNguoiDung { get; set; }

        // Thuộc tính điều hướng tới thực thể NguoiDung liên quan
        [ForeignKey("IdNguoiDung")]
        public virtual NguoiDung? NguoiDung { get; set; }
    }
}
