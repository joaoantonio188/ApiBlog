using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoApi.Migrations
{
    public partial class atualizaçãodevariaveis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "TodoItems",
                newName: "TituloBlog");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "TodoItems",
                newName: "DataCriação");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TituloBlog",
                table: "TodoItems",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "DataCriação",
                table: "TodoItems",
                newName: "Data");
        }
    }
}
