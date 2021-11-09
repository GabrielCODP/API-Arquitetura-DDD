using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class TestandoErro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Nome", "UpdateAt" },
                values: new object[] { new Guid("9a5792cc-6be5-448b-91e1-81cbc0b57652"), new DateTime(2021, 9, 27, 10, 50, 48, 539, DateTimeKind.Local).AddTicks(5539), "Dexter@gmail.com", "Administrador", new DateTime(2021, 9, 27, 10, 50, 48, 540, DateTimeKind.Local).AddTicks(2376) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9a5792cc-6be5-448b-91e1-81cbc0b57652"));
        }
    }
}
