using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class DoctorPatientConfigMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Devices_DeviceId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Schedules_ScheduleId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Dialogs_DialogId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DialogId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DialogId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Dialogs");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Dialogs");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DoctorPatient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DialogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Dialogs_DialogId",
                        column: x => x.DialogId,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "UserId");
                });

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
                name: "IX_DoctorPatient_DialogId",
                table: "DoctorPatient",
                column: "DialogId",
                unique: true,
                filter: "[DialogId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_DoctorId",
                table: "DoctorPatient",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_PatientId",
                table: "DoctorPatient",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Devices_DeviceId",
                table: "Doctors",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Schedules_ScheduleId",
                table: "Doctors",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Devices_DeviceId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Schedules_ScheduleId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "DoctorPatient");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "DialogId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecipientId",
                table: "Dialogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Dialogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "08050a80-bb3c-42f5-aaae-6404e153c186");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "a0580757-aa31-4aad-85af-4307fd2c55d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "99addf9f-c5ef-440f-83e9-0c4ce8f9375f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "082602cf-af70-4013-932d-458ca449c64c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c258aeb5-0bd9-444f-bca1-26ba3ce722e7", "AQAAAAEAACcQAAAAEE89hKdsfukrnaDmGgJTLjEY2AO926tJHWAs8u1C0GPBc49+SMUGA+rObBIOXUb1Sw==", "421a334b-e887-447f-bc8c-3d6dbe6ca51e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f337ff49-9130-4bd5-81bb-21bcbce28a29", "AQAAAAEAACcQAAAAENb+k3aJexqGO38ytxp6MSRRKMObmh/OC+rXGGxsNerwC1Xey3ldB+ZP6BHCzicHbw==", "e8f67c71-ebf8-4427-8c4c-4698cf66b14b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59034af1-098d-403e-9aef-901e8fd585e4", "AQAAAAEAACcQAAAAEAt9H4H0XfHT50EwuRI1pAYedexZvNKefGyOLNvQ1YBr8FXkDvVMAcdClwjrMGeLvg==", "1f1f32a0-491c-4202-b3e9-f37c554aed7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e123e262-c016-4a92-8fb3-4bf35e8b5fb5", "AQAAAAEAACcQAAAAEIcwrOCjLKUiRVCB266M7TVu8UgdHT2n/qq8yl21PtP8SyRyjY2fFDC7hlkEp22Dvw==", "183db323-a0c0-40af-a61d-ac2a94fafc30" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "UserId",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                column: "DoctorId",
                value: "E8D13331-62AB-463E-A283-6493B68A3622");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DialogId",
                table: "Patients",
                column: "DialogId",
                unique: true,
                filter: "[DialogId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Devices_DeviceId",
                table: "Doctors",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Schedules_ScheduleId",
                table: "Doctors",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Dialogs_DialogId",
                table: "Patients",
                column: "DialogId",
                principalTable: "Dialogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
