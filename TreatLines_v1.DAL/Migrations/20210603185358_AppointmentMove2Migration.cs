using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class AppointmentMove2Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorPatientId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "096d62d9-28a1-4a1a-8272-0f76122c96c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "6570c953-d477-4492-ad48-a099cba57265");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "cb9ed4bb-34f8-4503-9f31-6580945ab72a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "e999c40b-34b7-4213-a87c-4c8aae705446");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4437c594-49be-4a4c-9421-3a320cc233f3", "AQAAAAEAACcQAAAAELT81/o78Jo8HdqX5v+LNdVey5MQTGH0Rjk3X1eUkEQKqNHdRDJly11Z1MAS91pvaQ==", "00030cb6-b2da-4310-892b-2d2b261fae05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af82edb-e69e-46c3-9109-8314be81366b", "AQAAAAEAACcQAAAAEGk7D+Qp+vkl9jGHDDJ81PXPPwWUONaGliLM62dxYVNTNQgb+akBL/geY6a5SIKIDg==", "ef94fd5c-0659-4c9b-bb20-13be0d999ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3923ade-4e21-4c19-9ac3-6695f2ad1780", "AQAAAAEAACcQAAAAEE6tNPWb9OEGzN2+C2+qfQvo6wL6yY1WmT6aozzCY36xN9WKfyjnzV5NnBLfG49ZqA==", "65e3d945-ad37-4862-90a4-23b6e9397af1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03161177-7b3f-4ee9-984a-7c4894f82448", "AQAAAAEAACcQAAAAEJx2vsFWIOvYyA0gLxcKniUaxgCc7gdFb4g+DT9aB9D26L6hVKAOp1QhVsoSBfQMjQ==", "69344683-b438-47ad-bfdf-8d1606296b19" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorPatientId",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "16f12b2d-0b9a-45c0-9e5b-fb47945bd5e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "9f5da4ec-224a-4c1f-9929-16bd98e2c594");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "090e0416-0836-4de5-96ac-726e52dc2ba3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "2131f8c7-ebda-4a87-b2d9-10f842863581");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58a06aa-6d61-47f7-bb41-ca991337c1ab", "AQAAAAEAACcQAAAAEE3Te+gtirZomzzRkTAbL54H+qsB5bECrVZKNn602YpE2D1udf9ePR066ytxUlZwZg==", "661e6999-90df-4fe3-934b-72be37f3fe9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "798b935c-f9b2-47bc-82dd-3db17347ea4b", "AQAAAAEAACcQAAAAEAB8m6DVbkctCj84Kke/FfekAyz1vKBkjGhpoK9tV837gv71daOY0wlXUmqnx6rlQw==", "93228bfe-6343-4d0f-bad5-8b51283c39e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "246c5162-fe88-43fa-b2ea-e4cf4c8f0e8c", "AQAAAAEAACcQAAAAEOMP7p+6pShvYiP2BJLF/lLCnSUs2C8Slv8db6P0spJq1NowsbV5KS6L/Q0GIrJQgA==", "423897ea-3b90-41e1-bb05-5822cab43a7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5211e76f-bd9d-4d3c-9b50-8d9cdb9b637a", "AQAAAAEAACcQAAAAECGJcl0e/I3b+6/+1JdzWlYBGSYakFEVUqWnSMcn7mbkZN/67Y6CgNumXi3kcK9IZg==", "6ac15448-6b3e-45ed-b4a6-cc36a5c9c3af" });
        }
    }
}
