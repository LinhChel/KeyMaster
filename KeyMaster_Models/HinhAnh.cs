using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Models
{
    public class HinhAnh
    {
            [Key]
            public Guid IdImage { get; set; }
            public string FileName { get; set; } // Tên file
            public string FileType { get; set; } // Loại file (jpg, png, etc.)
            public byte[] Data { get; set; } // Dữ liệu hình ảnh dưới dạng byte
            public int ProductId { get; set; } // Khóa ngoại nếu liên kết với sản phẩm (nếu có)
    }
}
