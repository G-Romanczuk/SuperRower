using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperRowerDB.Migrations
{
    public partial class CustomersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNameCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityAdressCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAdressCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingAdressCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentAdressCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodCustomer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
