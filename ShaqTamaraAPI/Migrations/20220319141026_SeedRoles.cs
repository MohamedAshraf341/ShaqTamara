using Microsoft.EntityFrameworkCore.Migrations;
using ShaqTamaraAPI.Const;
using System;

namespace ShaqTamaraAPI.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.Admin.ToString(), Roles.Admin.ToString().ToUpper(), Guid.NewGuid().ToString() }
            );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.donor.ToString(), Roles.donor.ToString().ToUpper(), Guid.NewGuid().ToString() }
            );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.volunteer.ToString(), Roles.volunteer.ToString().ToUpper(), Guid.NewGuid().ToString() }
            );
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[] { Guid.NewGuid().ToString(), Roles.Beneficiary.ToString(), Roles.Beneficiary.ToString().ToUpper(), Guid.NewGuid().ToString() }
            );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Roles]");
        }
    }
}
