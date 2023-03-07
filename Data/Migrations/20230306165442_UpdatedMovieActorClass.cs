using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_jcollins.Data.Migrations
{
    public partial class UpdatedMovieActorClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTitle",
                table: "MovieActor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieTitle",
                table: "MovieActor");
        }
    }
}
