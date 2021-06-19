using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class CancelAppointmentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Canceled",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "280911d0-7c51-4251-b8e9-c36fb32cbdbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "13ac290f-8ab2-4904-bb52-08b6af0266f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "cd879a92-dcd1-4f5b-aedb-cc6064c83e99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "938a3400-c9fa-4b54-ad52-f117d6161a79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c57f3b-958f-443e-a6f0-7c9631b968a5", "AQAAAAEAACcQAAAAELyJjDCz0jpQWGnnkD0+ASZsdXIiIXmr7uuJxI6nbe1mH9Bri2L4pSau1izidBAmLA==", "dcedd36f-51a1-4c53-90a4-b6e80e849c0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cf891e9-ddb5-48cf-8d7f-be34b728a076", "AQAAAAEAACcQAAAAEKOrtDbH5TCi2ZCJVxtq3/cc1njXW+q3HJWh58rFB1RnHsrma6WbzTCs/1Sm/VCmHQ==", "259233fd-2f7e-4e16-854c-626893960c4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a101e1-b7e2-4cb4-a571-8c0320fc1a60", "AQAAAAEAACcQAAAAEPQeYf/+rcSaN66deWCcuJ41jeteGRoZuH1k4olygKDbBK4UqsNAN8s25WN8sQO9gA==", "8d9be02a-d7bf-4cd2-9986-525eccbce84a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dd5ce28-b1d1-4535-af22-d7bf9d5d9e0f", "AQAAAAEAACcQAAAAELjWrJQoqhZri2PmyuHc4491IZdlTwHDTp40YXOK90t9bVx+jx5OHiCYsutwnOJuvQ==", "e4364c84-689b-4b6d-84ff-e2769fb2535e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Canceled",
                table: "Appointments");

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
    }
}
