using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class BlockedUsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Blocked",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "0c46255f-ad13-49e2-804e-1b8d6547cdee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "b9a66d3e-98bd-44d4-997c-7ef611c19e1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "6f418120-cf80-4879-af29-f4a59f4214da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "325fca6c-d2f9-47e7-a59d-7c2d4d161490");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "580a8548-b734-47d2-8873-104c5bc636c0", "AQAAAAEAACcQAAAAENu+td/Rn9bLiPrLUivMAFG7zsOMZ6eajgZ+gyOK6zJuFUvfO8PkyBvbJlA7A7EBqA==", "ed396cb1-63ec-47c3-841c-693ca03b289e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edadd624-aab7-4e37-a03b-7810cf5c2fc1", "AQAAAAEAACcQAAAAENXPqLUfx8k8LTPzmNqyPxXOMmXp+M7S3iiHLs5tQOLRrXuc7p2yXUHZp5WUWouGcA==", "a8d4c1f8-9b9c-40db-afc6-0bd01412de60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af22b9a-60fa-4ca3-807e-04a34a282bc2", "AQAAAAEAACcQAAAAEGJhLC37SVxZUC2PoPtJWZfqwgomNR/iYfqKsWvybRvIXJ8FPkJGz5oidVxCSBN4qw==", "30a9ee26-25c0-463b-a429-537d399f3dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50c8ec3d-e677-4494-825a-44dd7e73ffcc", "AQAAAAEAACcQAAAAEMPgYUgAJDZy7SsXw3FijyaTJN1+AHZSLptjjtVh54FU4BNheO1W6xYs/ijgiNjSqA==", "f367f72a-029a-4a12-828e-abff949249f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blocked",
                table: "AspNetUsers");

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
    }
}
