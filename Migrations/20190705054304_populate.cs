using Microsoft.EntityFrameworkCore.Migrations;

namespace LCMWebAPI.Migrations
{
    public partial class populate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from AlgorithmTypes");
            migrationBuilder.Sql("SET IDENTITY_INSERT AlgorithmTypes ON");
            migrationBuilder.Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (1, 'Best time complexity')");
            migrationBuilder.Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (2, 'Best space complexity')");
            migrationBuilder.Sql("INSERT INTO AlgorithmTypes (Id, Name) VALUES (3, 'Optimal time and space complexity')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
