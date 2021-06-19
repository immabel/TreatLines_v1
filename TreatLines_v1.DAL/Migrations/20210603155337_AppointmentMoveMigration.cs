using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class AppointmentMoveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "DoctorPatient",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_AppointmentId",
                table: "DoctorPatient",
                column: "AppointmentId",
                unique: true,
                filter: "[AppointmentId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatient_Appointments_AppointmentId",
                table: "DoctorPatient",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatient_Appointments_AppointmentId",
                table: "DoctorPatient");

            migrationBuilder.DropIndex(
                name: "IX_DoctorPatient_AppointmentId",
                table: "DoctorPatient");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "DoctorPatient");

            migrationBuilder.DropColumn(
                name: "DoctorPatientId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "70540816-6248-4971-b9a2-d6703e31932b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "86975d5a-8a3e-465d-a53a-c64b93aebacb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "26dbc09c-b9b4-429d-8460-edf6f65c0c33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "70e682e4-6c1d-4452-8c28-7459167ac146");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27d56e2c-6246-4588-9a0a-b7d7fe7ff6f2", "AQAAAAEAACcQAAAAECSkLTg/FQ7VeYwc5sRpORb7oZJoh+BEVZpDZUEF1IwDgY9DYG/rEU2jW0Z2l6Rf2w==", "8bc42f96-09e1-4d1a-acfc-9853e7a5199d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa417452-3568-4a20-a8e3-1c63208b854b", "AQAAAAEAACcQAAAAEGhOGF8/WDoXZl8ivOIR3+9iZkoALvqPmFWe6STKcknBK1OQYDO+F5KmzE+91mG+oA==", "d0a731bf-a73a-4ad3-9451-2c8e19156640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d75208dc-4f03-49e6-941b-a751e05d6ed0", "AQAAAAEAACcQAAAAEIvbgKPF2N1MjwP8MJO2aeMpWv6Wj57wCyeyn8OYpu/IXqXP7RC0doGuPc7cVRM7nA==", "3ef62218-c365-4f9a-9bc3-38c7d165a431" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f1d8e0a-462b-4e3f-b1e7-010b29779d0a", "AQAAAAEAACcQAAAAEBjbyNacZ8zNjBZrclLejhk84FxR7RRKW9MAck2X11GdNiGYOKcQOcqBxrkznTU23g==", "7ad194ca-f7f2-4875-a19b-dcb03d490519" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
