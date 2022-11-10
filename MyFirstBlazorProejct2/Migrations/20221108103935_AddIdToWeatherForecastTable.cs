﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstBlazorProejct2.Migrations
{
    public partial class AddIdToWeatherForecastTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WeatherForecast",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "WeatherForecast");
        }
    }
}
