using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRSProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AREA_MASTER",
                columns: table => new
                {
                    AREA_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AREA_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AREA_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREA_MASTER", x => x.AREA_ID);
                });

            migrationBuilder.CreateTable(
                name: "EQUIPMENT_MASTER",
                columns: table => new
                {
                    EQUIPMENT_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQUIPMENT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQUIPMENT_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ASSET_NO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RANK = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MAKER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IMPORT_TYPE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PLACE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    YEAR_OF_INSTALLATION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AGE = table.Column<int>(type: "int", nullable: false),
                    EQUIPMENT_CATEGORY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EQUIPMENT_CATEGORY01 = table.Column<string>(name: "EQUIPMENT_CATEGORY-01", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EQUIPMENT_CATEGORY02 = table.Column<string>(name: "EQUIPMENT_CATEGORY-02", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    COMMENTS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATION_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LINE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AREA_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EQUIPMENT_MASTER", x => x.EQUIPMENT_ID);
                });

            migrationBuilder.CreateTable(
                name: "FAULT_MASTER",
                columns: table => new
                {
                    FAULT_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FAULT_MASTER_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FAULT_DESCRIPTION = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EQUIPMENT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAULT_MASTER", x => x.FAULT_ID);
                });

            migrationBuilder.CreateTable(
                name: "LINE_MASTER",
                columns: table => new
                {
                    LINE_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LINE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LINE_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LINE_DISCRPTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AREA_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LINE_MASTER", x => x.LINE_ID);
                });

            migrationBuilder.CreateTable(
                name: "MANUAL_MASTER",
                columns: table => new
                {
                    MANUAL_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQUIPMENT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MANUAL_CODE = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MANUAL_DOCUMNET = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MANUAL_CATEGORY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MANUAL_MASTER", x => x.MANUAL_ID);
                });

            migrationBuilder.CreateTable(
                name: "PLANT_MASTER",
                columns: table => new
                {
                    PLANT_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PLANT_LOCATION = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PLANT_DESCRIPTION = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PLANT_HEAD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_START_YEAR = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLANT_MASTER", x => x.PLANT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SHIFT_MASTER",
                columns: table => new
                {
                    SHIFT_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHIFT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHIFT_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SHIFT_CATEGORY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SHIFT_START_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SHIFT_END_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHIFT_MASTER", x => x.SHIFT_ID);
                });

            migrationBuilder.CreateTable(
                name: "SHOP_MASTER",
                columns: table => new
                {
                    SHOP_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_LOCATION = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SHOP_INCHARGE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SHOP_SECTION_INCHARGE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SHOP_COST_CENTER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SHOP_DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHOP_MASTER", x => x.SHOP_ID);
                });

            migrationBuilder.CreateTable(
                name: "SPARE_EQUIPMENT_MAPPINGS",
                columns: table => new
                {
                    SPEQ_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SPARE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SPARE_YZA_NUMBER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQUIPMENT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPARE_EQUIPMENT_MAPPINGS", x => x.SPEQ_ID);
                });

            migrationBuilder.CreateTable(
                name: "SPARE_MASTER",
                columns: table => new
                {
                    SPARE_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SPARE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    YZA_NUMBER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EQUIPMENT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LINE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AREA_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PART_DESCRIPTION = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SPECIFICATION = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    STOCK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    QUANTITY = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PART_LOCATION = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SUPPLIER_DETAILS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MAKER = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CATEGORY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IMPORT_TYPE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ESTORE_CATEGORY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EQUIPMENT_WARRANTY = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPARE_MASTER", x => x.SPARE_ID);
                });

            migrationBuilder.CreateTable(
                name: "STATION_MASTER",
                columns: table => new
                {
                    STATION_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    STATION_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    STATION_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LINE_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AREA_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SHOP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PLANT_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATION_MASTER", x => x.STATION_ID);
                });

            migrationBuilder.CreateTable(
                name: "TEAM_MASTER",
                columns: table => new
                {
                    TEAM_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TEAM_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TEAM_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TEAM_CATEGORY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEAM_MASTER", x => x.TEAM_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AREA_MASTER");

            migrationBuilder.DropTable(
                name: "EQUIPMENT_MASTER");

            migrationBuilder.DropTable(
                name: "FAULT_MASTER");

            migrationBuilder.DropTable(
                name: "LINE_MASTER");

            migrationBuilder.DropTable(
                name: "MANUAL_MASTER");

            migrationBuilder.DropTable(
                name: "PLANT_MASTER");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SHIFT_MASTER");

            migrationBuilder.DropTable(
                name: "SHOP_MASTER");

            migrationBuilder.DropTable(
                name: "SPARE_EQUIPMENT_MAPPINGS");

            migrationBuilder.DropTable(
                name: "SPARE_MASTER");

            migrationBuilder.DropTable(
                name: "STATION_MASTER");

            migrationBuilder.DropTable(
                name: "TEAM_MASTER");
        }
    }
}
