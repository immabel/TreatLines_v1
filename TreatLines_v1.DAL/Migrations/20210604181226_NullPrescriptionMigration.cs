using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class NullPrescriptionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "cffee31c-dc58-465d-b00d-88e1d9749b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "93a6ed27-27c6-4085-95ac-eea6d096da3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "2d52d24a-1f11-47ae-97b4-4de074be6309");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "6a4d4b73-529d-4913-8d75-c7b131d0b8fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c655a56-d103-4b76-adf0-bd7e50cba5a8", "AQAAAAEAACcQAAAAENAm5YUx/UvPweYwJXuv5dObu0e7s6601DxqmjmquJs/wy6MMDj6NlnPOnpMLnkz0Q==", "bc5fa690-d382-4144-9668-69e1e85aec01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3782114-95f2-4ec5-92cb-67c5f8fc6080", "AQAAAAEAACcQAAAAEEyPIX3ItqJG9EgPU3GgUtg5+W55XXclRGX4+4Dyv6wz2oAd/0bNCLNUKdv5c39+Ig==", "e9c34b31-4ebb-4882-9446-a27b4bf34e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d878f5aa-fe47-4b41-9a20-6eb69c36746b", "AQAAAAEAACcQAAAAEEOqtgJ60qId5HpiqfR32RIwLgdb4zudt/MeWpGbF+9alWVElGjVDxxnM4wSipp6CQ==", "9cd05f93-d365-4249-b6ec-8792c262a73f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfd45fda-0cf1-4fdb-ab44-09806d60f0b1", "AQAAAAEAACcQAAAAEFcboCXRBTae95Ezzxgv+9tFCrzmc4qIJo9/O6lgj7KHVAD1Z2otcr5KQv1cDjkkYg==", "3d3f296d-3d8f-46a0-9755-f917755a547f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
