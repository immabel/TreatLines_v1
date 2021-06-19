using Microsoft.EntityFrameworkCore.Migrations;

namespace TreatLines_v1.DAL.Migrations
{
    public partial class AddPrescriptMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Patients",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PrescriptionId",
                table: "Appointments",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Prescriptions_PrescriptionId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PrescriptionId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2AEFE1C5-C5F0-4399-8FB8-420813567554",
                column: "ConcurrencyStamp",
                value: "0f23dc36-171c-4bc3-b8c5-e43069f2df26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422EEB6A-3031-4B66-ABA8-0F85AFC07C3C",
                column: "ConcurrencyStamp",
                value: "ed793cc9-c27b-47e2-b186-20e4b7e1ff5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "828A3B02-77C0-45C1-8E97-6ED57711E577",
                column: "ConcurrencyStamp",
                value: "12f76ba1-fd7a-44bb-99ea-d753936d12a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99DA7670-5471-414F-834E-9B3A6B6C8F6F",
                column: "ConcurrencyStamp",
                value: "8126f5b3-efd2-46cd-b41c-392095f2a351");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00CA41A9-C962-4230-937E-D5F54772C062",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ac6e9d-626c-4775-b34d-51ac573c74f8", "AQAAAAEAACcQAAAAEP9gJcNbotfxSBQkcrcLIBAf2L/1Ta3oVoBWpOy6cu55cXmnEbc6comR8feSgy3h4Q==", "a8e81e5a-5dae-4e03-a9a7-c0dda731dcd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "BFCC8BAB-AD20-4F70-9CD9-D2003FAE6F09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba7c9ad1-7131-4cc2-a6e2-425bb0a26a53", "AQAAAAEAACcQAAAAEFTw9H463qzVAUt0e/xIMYKBZZ69vFz8Ql7r5yLsBBEjjUWJtvi2sUm+KWbfLoQc+A==", "c31418d2-19f5-4c09-80c6-e1e5d06ba945" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E3A6BF34-A57D-4709-97CC-6AD1B2B3985B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6249b4c9-7b01-41db-82e1-737b1620cfdd", "AQAAAAEAACcQAAAAELtC7g2weM7i+FjKjYnLTXT/kJ2Cg8b5HxBiYwlWuELqFoHdNIv3tJO0b5YR+wxNAg==", "2a302422-9130-4acd-8fce-999864c7cdb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E8D13331-62AB-463E-A283-6493B68A3622",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "617b4224-1192-48a7-840b-a168f485392e", "AQAAAAEAACcQAAAAEIip+hOY5mPjscrooYcQM+ILECb3W5bEB6wb9D0VdrYKBDAiGc/llKbTGa6QeZzCAQ==", "5fc8d3b9-5897-4cd6-b180-cecad6e2a9a3" });
        }
    }
}
