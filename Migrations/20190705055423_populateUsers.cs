using Microsoft.EntityFrameworkCore.Migrations;

namespace LCMWebAPI.Migrations
{
    public partial class populateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Users");
            migrationBuilder.Sql("SET IDENTITY_INSERT Users ON");
            migrationBuilder.Sql("INSERT INTO Users (Id, Email, Password) VALUES (1, 'rohitkori', 'rohitkori')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
