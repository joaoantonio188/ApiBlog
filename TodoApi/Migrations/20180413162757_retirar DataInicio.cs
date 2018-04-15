using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoApi.Migrations
{
    public partial class retirarDataInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "TodoItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "TodoItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
