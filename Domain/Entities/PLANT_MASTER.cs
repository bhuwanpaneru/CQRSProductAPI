using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CQRSProductAPI.Domain.Entities
{

    [Table("PLANT_MASTER")]
    public class PlantMaster
    {
        [Key]
        [Column("PLANT_ID")]
        [StringLength(10)]
        public string PlantId { get; set; } = "PM0001"; // Default value

        [Required]
        [Column("PLANT_CODE")]
        [StringLength(10)]
        public string PlantCode { get; set; }

        [Required]
        [Column("PLANT_NAME")]
        [StringLength(20)]
        public string PlantName { get; set; }

        [Required]
        [Column("PLANT_LOCATION")]
        [StringLength(40)]
        public string PlantLocation { get; set; }

        [Required]
        [Column("PLANT_DESCRIPTION")]
        [StringLength(40)]
        public string PlantDescription { get; set; }

        [Required]
        [Column("PLANT_HEAD")]
        [StringLength(10)]
        public string PlantHead { get; set; }

        [Required]
        [Column("PLANT_START_YEAR")]
        public DateTime PlantStartYear { get; set; }

        [Required]
        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column("CREATED_BY")]
        public int CreatedBy { get; set; }

        [Required]
        [Column("UPDATED_BY")]
        public int UpdatedBy { get; set; }

        [Required]
        [Column("UPDATED_DATE")]
        public DateTime UpdatedDate { get; set; }
    }
}
