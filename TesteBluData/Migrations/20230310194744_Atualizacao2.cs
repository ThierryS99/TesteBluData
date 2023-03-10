using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteBluData.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Fornecedor",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Fornecedor");
        }
    }
}
