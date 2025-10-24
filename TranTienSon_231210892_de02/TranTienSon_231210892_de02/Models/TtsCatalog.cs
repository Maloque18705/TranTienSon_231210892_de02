using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranTienSon_231210892_de02.Models

{
    [Table("TtsCatalog")]
    public class TtsCatalog
    {
        [Key]
        public int TtsId { get; set; }
        public string TtsCateName { get; set; }
        public int TtsCatePrice { get; set; }
        public int TtsCateQty { get; set; }
        public string? TtsPicture { get; set; }
        public bool TtsCateActive { get;set; }
    }
}
