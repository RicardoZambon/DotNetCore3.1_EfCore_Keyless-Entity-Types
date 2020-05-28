using System.ComponentModel.DataAnnotations;

namespace EFCoreKeylessEntityTypes.Entities
{
    public class QLink
    {
        [StringLength(10), Key]
        public string QNumber { get; set; }

        [StringLength(10)]
        public string QGroup { get; set; }
    }
}