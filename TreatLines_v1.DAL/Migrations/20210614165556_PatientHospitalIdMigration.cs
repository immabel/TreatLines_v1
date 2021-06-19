using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class PatientHospitalIdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HospitalId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "6cfdeaef-3b28-4cf6-acc2-ccd870262153");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "29117cd9-3355-4e94-afcd-2520e3a8d09b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "625a0e04-321d-4abc-aa6a-4a68b94d5cc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "6f609dca-7c80-4626-8ca8-c29ed38d8207");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31369a09-b58d-484f-9ea1-f9311d6c094b", "AQAAAAEAACcQAAAAECAmjt3CGRBeQ+tlmNk1ro6oosxUWcioXtDnaZL6CvswygBApTliS7Iii3Dd8bpAfw==", "4ae6edd6-78b0-499c-a88a-e4576114c1c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f2c2df6-a3b7-4ecb-9b12-8723d9290cb5", "AQAAAAEAACcQAAAAEMbUpxq9aLGmO64oja+9Q27Paztp1Ieypj7jjXofZfE62mkt1OiCb0HyiOip6ZN/0w==", "f0dff04d-48a3-45a3-a31c-0b68b486feca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3902dba-9eba-4ca2-9858-225a3a366537", "AQAAAAEAACcQAAAAEN6FnOSPw6m7FYWNdsLZQwZan5TXYTe2uz5aQvTyHvvY2O3fJMO+haqgFnDqrJ6fBg==", "ad4d8203-f15a-47ec-ac40-f5e9f5583e1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44c73ab8-7ad2-454d-97f3-1797ccac1074", "AQAAAAEAACcQAAAAEFzTWRheFmj9RFz4GB/fI1CH7vWiggKAGQKDzjjFfvXXcGjpDLt4Tm9kCP0NAOpezg==", "0b2cf9eb-d3fb-46a4-8160-1085d02c5a1f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalId",
                table: "Patients");

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
    }
}
