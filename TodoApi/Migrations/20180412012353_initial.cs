using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComentarioNota = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    DataTexto = table.Column<string>(nullable: true),
                    DonoBlog = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Nota = table.Column<float>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");
        }
    }
}
