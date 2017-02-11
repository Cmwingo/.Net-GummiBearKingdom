using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBearKingdom.Migrations
{
    public partial class MakeCostDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Products",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "Products",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "Products",
                nullable: false);
        }
    }
}
