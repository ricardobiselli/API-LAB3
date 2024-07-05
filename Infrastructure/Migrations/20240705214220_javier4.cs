﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class javier4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compatibility_Products_ProductId",
                table: "Compatibility");

            migrationBuilder.AddForeignKey(
                name: "FK_Compatibility_Products_ProductId",
                table: "Compatibility",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compatibility_Products_ProductId",
                table: "Compatibility");

            migrationBuilder.AddForeignKey(
                name: "FK_Compatibility_Products_ProductId",
                table: "Compatibility",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
