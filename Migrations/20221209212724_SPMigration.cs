using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankClientApi.Migrations
{
    public partial class SPMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //string sql = @"
            //CREATE PROCEDURE dbo.GetCities
            //@id int
            //AS
            //BEGIN
            //    SELECT * FROM dbo.Cities
            //END";

            //migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //string sql = "DROP PROCEDURE dbo.GetCities";

            //migrationBuilder.Sql(sql);
        }
    }
}
