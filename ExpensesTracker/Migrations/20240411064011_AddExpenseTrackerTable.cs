using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpensesTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddExpenseTrackerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseTracker",
                columns: table => new
                {
                    ET_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ET_Expense_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ET_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    ET_Amount = table.Column<double>(type: "float", nullable: false),
                    ET_RefundYN = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ET_Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTracker", x => x.ET_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseTracker");
        }
    }
}
