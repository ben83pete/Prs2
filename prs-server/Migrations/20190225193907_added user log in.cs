using Microsoft.EntityFrameworkCore.Migrations;

namespace prs.Migrations
{
    public partial class addeduserlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Qty",
                table: "Request_Lines",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Qty",
                table: "Request_Lines",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);
        }
    }
}
