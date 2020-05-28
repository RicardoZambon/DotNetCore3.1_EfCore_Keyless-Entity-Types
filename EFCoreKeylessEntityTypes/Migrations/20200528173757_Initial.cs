using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreKeylessEntityTypes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QLink",
                columns: table => new
                {
                    QNumber = table.Column<string>(maxLength: 10, nullable: false),
                    QGroup = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLink", x => x.QNumber);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    SalesOrder = table.Column<string>(maxLength: 10, nullable: false),
                    QNumber = table.Column<string>(maxLength: 10, nullable: true),
                    QLinkQNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.SalesOrder);
                    table.ForeignKey(
                        name: "FK_SalesOrders_QLink_QLinkQNumber",
                        column: x => x.QLinkQNumber,
                        principalTable: "QLink",
                        principalColumn: "QNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrdersItems",
                columns: table => new
                {
                    SalesOrderItem = table.Column<string>(maxLength: 10, nullable: false),
                    SalesOrder = table.Column<string>(maxLength: 10, nullable: true),
                    PartNumber = table.Column<string>(maxLength: 20, nullable: true),
                    OrderQuantity = table.Column<decimal>(nullable: false),
                    UHeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrdersItems", x => x.SalesOrderItem);
                    table.ForeignKey(
                        name: "FK_SalesOrdersItems_SalesOrders_SalesOrder",
                        column: x => x.SalesOrder,
                        principalTable: "SalesOrders",
                        principalColumn: "SalesOrder",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_QLinkQNumber",
                table: "SalesOrders",
                column: "QLinkQNumber");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrdersItems_SalesOrder",
                table: "SalesOrdersItems",
                column: "SalesOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesOrdersItems");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "QLink");
        }
    }
}
