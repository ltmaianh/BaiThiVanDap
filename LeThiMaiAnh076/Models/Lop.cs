using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeThiMaiAnh076{
    
        [Table("Lop")]
        public class Lop{
        [Key]
        public string TenLop { get; set; }
        public string MaLop { get; set; }
        public string SoDienThoai { get; set; }
    }
}