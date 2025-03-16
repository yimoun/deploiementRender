﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StationnementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePaiement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AbonnementId",
                table: "Paiement",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Paiement",
                keyColumn: "AbonnementId",
                keyValue: null,
                column: "AbonnementId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "AbonnementId",
                table: "Paiement",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
