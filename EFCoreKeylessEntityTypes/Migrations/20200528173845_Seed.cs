using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreKeylessEntityTypes.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QLink",
                columns: new[] { "QNumber", "QGroup" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "9", "3" },
                    { "8", "3" },
                    { "7", "2" },
                    { "6", "2" },
                    { "10", "4" },
                    { "4", "1" },
                    { "3", "1" },
                    { "2", "1" },
                    { "5", "2" }
                });

            migrationBuilder.InsertData(
                table: "SalesOrders",
                columns: new[] { "SalesOrder", "QLinkQNumber", "QNumber" },
                values: new object[,]
                {
                    { "11", null, "6" },
                    { "18", null, "9" },
                    { "17", null, "9" },
                    { "16", null, "8" },
                    { "15", null, "8" },
                    { "14", null, "7" },
                    { "13", null, "7" },
                    { "12", null, "6" },
                    { "10", null, "6" },
                    { "5", null, "3" },
                    { "8", null, "4" },
                    { "7", null, "4" },
                    { "6", null, "3" },
                    { "19", null, "10" },
                    { "4", null, "2" },
                    { "3", null, "2" },
                    { "2", null, "1" },
                    { "1", null, "1" },
                    { "9", null, "5" },
                    { "20", null, "10" }
                });

            migrationBuilder.InsertData(
                table: "SalesOrdersItems",
                columns: new[] { "SalesOrderItem", "OrderQuantity", "PartNumber", "SalesOrder", "UHeight" },
                values: new object[,]
                {
                    { "1", 10m, "1", "1", 0 },
                    { "28", 55m, "4", "19", 0 },
                    { "27", 20m, "3", "19", 0 },
                    { "26", 10m, "2", "19", 0 },
                    { "25", 100m, "2", "18", 0 },
                    { "24", 90m, "1", "18", 0 },
                    { "23", 80m, "1", "17", 0 },
                    { "22", 60m, "4", "16", 0 },
                    { "21", 20m, "3", "15", 0 },
                    { "20", 30m, "2", "14", 0 },
                    { "19", 80m, "4", "13", 0 },
                    { "18", 90m, "1", "12", 0 },
                    { "17", 40m, "3", "12", 0 },
                    { "16", 50m, "2", "11", 0 },
                    { "15", 60m, "5", "10", 0 },
                    { "14", 10m, "4", "9", 0 },
                    { "13", 20m, "3", "8", 0 },
                    { "12", 30m, "2", "7", 0 },
                    { "11", 40m, "1", "6", 0 },
                    { "10", 40m, "4", "5", 0 },
                    { "9", 50m, "3", "5", 0 },
                    { "8", 60m, "2", "5", 0 },
                    { "7", 40m, "3", "4", 0 },
                    { "6", 30m, "2", "4", 0 },
                    { "5", 40m, "2", "3", 0 },
                    { "4", 70m, "1", "3", 0 },
                    { "3", 40m, "3", "2", 0 },
                    { "2", 20m, "2", "1", 0 },
                    { "29", 78m, "5", "20", 0 },
                    { "30", 45m, "1", "20", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "QLink",
                keyColumn: "QNumber",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "SalesOrdersItems",
                keyColumn: "SalesOrderItem",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "SalesOrders",
                keyColumn: "SalesOrder",
                keyValue: "9");
        }
    }
}
