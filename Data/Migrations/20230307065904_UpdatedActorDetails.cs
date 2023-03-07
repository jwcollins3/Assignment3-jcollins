using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_jcollins.Data.Migrations
{
    public partial class UpdatedActorDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActorGender",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorGender",
                table: "Actor");
        }
    }
}
