using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperRowerDB.Migrations
{
    public partial class Transactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerIF = table.Column<int>(type: "int", nullable: false),
                    RowerPriceIF = table.Column<int>(type: "int", nullable: false),
                    RowerRentIF = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_Customers_CustomerIF",
                        column: x => x.CustomerIF,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Prices_RowerPriceIF",
                        column: x => x.RowerPriceIF,
                        principalTable: "Prices",
                        principalColumn: "RowerPriceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_RowerRents_RowerRentIF",
                        column: x => x.RowerRentIF,
                        principalTable: "RowerRents",
                        principalColumn: "RowerRentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerIF",
                table: "Transactions",
                column: "CustomerIF");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_RowerPriceIF",
                table: "Transactions",
                column: "RowerPriceIF");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_RowerRentIF",
                table: "Transactions",
                column: "RowerRentIF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
