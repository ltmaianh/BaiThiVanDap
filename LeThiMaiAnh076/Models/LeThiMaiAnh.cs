using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeThiMaiAnh076{
    
        [Table("LeThiMaiAnh")]
        public class LeThiMaiAnh{
        [Key]
        public string HoTen { get; set; }
        public int MaSV { get; set; }
        public float Diem { get; set; }
    }
}