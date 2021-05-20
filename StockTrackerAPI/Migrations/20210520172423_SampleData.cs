using Microsoft.EntityFrameworkCore.Migrations;

namespace StockTrackerAPI.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "AlphaCode", "Name", "Price", "closingPrice", "url" },
                values: new object[,]
                {
                    { 1, "FGZMX", "Guzman Inc", 136.41m, 178.24m, "https://www.nasdaq.com/market-activity/funds-and-etfs/fgzmx" },
                    { 2, "GOOGL", "Google", 3343.31m, 2000.50m, "https://www.nasdaq.com/market-activity/stocks/goog" },
                    { 3, "AMZN", "Amazon", 287.81m, 250.00m, "https://www.nasdaq.com/market-activity/stocks/amzn" },
                    { 4, "WMT", "Walmart Inc", 14.81m, 14.60m, "https://www.nasdaq.com/market-activity/stocks/wmt" },
                    { 5, "AMD", "Advanced Micro Devices, Inc.", 14.64m, 10.25m, "https://www.nasdaq.com/market-activity/stocks/amd" },
                    { 6, "ZNGA", "Zynga Inc.", 10.70m, 8.62m, "https://www.nasdaq.com/market-activity/stocks/znga" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
