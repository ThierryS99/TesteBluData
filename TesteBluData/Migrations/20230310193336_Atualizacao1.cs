using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteBluData.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Fornecedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Fornecedor",
                type: "datetime2",
                nullable: true);
        }
    }
}
