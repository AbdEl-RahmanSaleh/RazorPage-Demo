﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Departments");
        }
    }
}
