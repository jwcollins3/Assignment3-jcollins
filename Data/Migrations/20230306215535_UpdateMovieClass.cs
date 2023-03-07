using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3_jcollins.Data.Migrations
{
    public partial class UpdateMovieClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "MoviePoster",
                table: "Movie",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieUrl",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ActorPhoto",
                table: "Actor",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActorUrl",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoviePoster",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MovieUrl",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ActorPhoto",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "ActorUrl",
                table: "Actor");
        }
    }
}
