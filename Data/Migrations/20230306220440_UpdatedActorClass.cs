using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_jcollins.Data.Migrations
{
    public partial class UpdatedActorClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieGenre",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieGenre",
                table: "Movie");
        }
    }
}
