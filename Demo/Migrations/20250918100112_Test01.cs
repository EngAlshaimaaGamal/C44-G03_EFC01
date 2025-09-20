using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class Test01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employees",
                newName: "Emp_Salary");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employees",
                newName: "Emp_Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Emp_Salary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "Emp_Age",
                table: "Employees",
                newName: "Age");
        }
    }
}
