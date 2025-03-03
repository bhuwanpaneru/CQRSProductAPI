using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CQRSProductAPI.Domain.Entities
{
    [Table("SHOP_MASTER")]
    public class ShopMaster
    {
        [Key]
        [Column("SHOP_ID")]
        [StringLength(10)]
        public string ShopId { get; set; } = "SH00001"; // Default value

        [Required]
        [Column("SHOP_CODE")]
        [StringLength(10)]
        public string ShopCode { get; set; }

        [Required]
        [Column("SHOP_NAME")]
        [StringLength(20)]
        public string ShopName { get; set; }

        [Required]
        [Column("PLANT_CODE")]
        [StringLength(10)]
        public string PlantCode { get; set; } // Foreign Key

        [Required]
        [Column("SHOP_LOCATION")]
        [StringLength(40)]
        public string ShopLocation { get; set; }

        [Required]
        [Column("SHOP_INCHARGE")]
        [StringLength(50)]
        public string ShopIncharge { get; set; }

        [Required]
        [Column("SHOP_SECTION_INCHARGE")]
        [StringLength(50)]
        public string ShopSectionIncharge { get; set; }

        [Required]
        [Column("SHOP_COST_CENTER")]
        [StringLength(50)]
        public string ShopCostCenter { get; set; }

        [Required]
        [Column("SHOP_DESCRIPTION")]
        [StringLength(100)]
        public string ShopDescription { get; set; }

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
