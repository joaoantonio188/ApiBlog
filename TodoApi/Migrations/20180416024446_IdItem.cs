using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoApi.Migrations
{
    public partial class IdItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Iditem",
                table: "TodoItems",
                newName: "IdItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdItem",
                table: "TodoItems",
                newName: "Iditem");
        }
    }
}
