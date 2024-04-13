using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpensesTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedExpenseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExpenseTracker",
                columns: new[] { "ET_Id", "ET_Amount", "ET_Comments", "ET_Date", "ET_Expense_Name", "ET_RefundYN" },
                values: new object[,]
                {
                    { 1, 20.0, null, new DateOnly(2024, 2, 25), "test", "N" },
                    { 2, 80.0, null, new DateOnly(2024, 1, 15), "test", "N" },
                    { 3, 50.0, null, new DateOnly(2024, 1, 22), "test", "Y" },
                    { 4, 30.0, null, new DateOnly(2024, 2, 28), "test", "Y" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpenseTracker",
                keyColumn: "ET_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseTracker",
                keyColumn: "ET_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseTracker",
                keyColumn: "ET_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseTracker",
                keyColumn: "ET_Id",
                keyValue: 4);
        }
    }
}
