using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HolidayWallet.Data.Migrations
{
    /// <inheritdoc />
    public partial class Holidays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Holidays_HolidayId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.RenameTable(
                name: "Holidays",
                newName: "Holiday");

            migrationBuilder.RenameTable(
                name: "Expenses",
                newName: "Expense");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_HolidayId",
                table: "Expense",
                newName: "IX_Expense_HolidayId");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Expense",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expense",
                table: "Expense",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConversionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expense_CurrencyId",
                table: "Expense",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Currency_CurrencyId",
                table: "Expense",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Holiday_HolidayId",
                table: "Expense",
                column: "HolidayId",
                principalTable: "Holiday",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Currency_CurrencyId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Holiday_HolidayId",
                table: "Expense");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expense",
                table: "Expense");

            migrationBuilder.DropIndex(
                name: "IX_Expense_CurrencyId",
                table: "Expense");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Expense");

            migrationBuilder.RenameTable(
                name: "Holiday",
                newName: "Holidays");

            migrationBuilder.RenameTable(
                name: "Expense",
                newName: "Expenses");

            migrationBuilder.RenameIndex(
                name: "IX_Expense_HolidayId",
                table: "Expenses",
                newName: "IX_Expenses_HolidayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Holidays_HolidayId",
                table: "Expenses",
                column: "HolidayId",
                principalTable: "Holidays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
