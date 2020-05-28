using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreKeylessEntityTypes.Migrations
{
	public partial class Procedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
			CREATE OR ALTER PROCEDURE [dbo].[AvailablePartsforRackBuild]
			  @QNumber VARCHAR(10)
			AS
			BEGIN
				DECLARE @QGroup VARCHAR(10)
				DECLARE @SalesOrder VARCHAR(10)

				SELECT @QGroup=QGroup FROM QLink WHERE QNumber = @QNumber
				SELECT @SalesOrder=SalesOrder FROM SalesOrders WHERE QNumber = @QNumber

				DECLARE @SO AS TABLE (SalesOrder VARCHAR(10))
  
				INSERT INTO @SO (SalesOrder)
				SELECT SalesOrder FROM SalesOrders 
				WHERE QNumber IN (SELECT DISTINCT QNumber FROM QLink WHERE QGroup = @QGroup)

				IF NOT EXISTS (SELECT SalesOrder FROM @SO WHERE SalesOrder = @SalesOrder)
				INSERT INTO @SO VALUES (@SalesOrder)

				SELECT SO.SalesOrder,SI.SalesOrderItem,SO.QNumber,SI.PartNumber,SI.OrderQuantity,SI.UHeight
				FROM SalesOrders SO
				INNER JOIN SalesOrdersItems SI
				ON SO.SalesOrder = SI.SalesOrder
				WHERE SO.SalesOrder IN (SELECT SalesOrder FROM @SO)
				AND SI.OrderQuantity > 1
			END
			GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}