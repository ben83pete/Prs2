using Microsoft.EntityFrameworkCore.Migrations;

namespace prs.Migrations
{
    public partial class ziptostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Vendors",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Zipcode",
                table: "Vendors",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true);
        }
    }
}
