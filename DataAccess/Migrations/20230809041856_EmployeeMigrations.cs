using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees_Application.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StaffCode",
                table: "Employees",
                newName: "CompanyCategory");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "CompanyCategory",
                table: "Employees",
                newName: "StaffCode");
        }
    }
}
