using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreFinanceApp.Data.Migrations
{
    public partial class inversionofrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    FlatNumber = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    PostOfficeCity = table.Column<string>(nullable: true),
                    CorrespondenceStreetName = table.Column<string>(nullable: true),
                    CorrespondenceStreetNumber = table.Column<string>(nullable: true),
                    CorrespondenceFlatNumber = table.Column<string>(nullable: true),
                    CorrespondencePostCode = table.Column<string>(nullable: true),
                    CorrespondencePostOfficeCity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialStates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OutstandingLiabilities = table.Column<decimal>(nullable: false),
                    Interests = table.Column<decimal>(nullable: false),
                    PenaltyInterests = table.Column<decimal>(nullable: false),
                    Fees = table.Column<decimal>(nullable: false),
                    CourtFees = table.Column<decimal>(nullable: false),
                    RepresentationCourtFees = table.Column<decimal>(nullable: false),
                    VindicationCosts = table.Column<decimal>(nullable: false),
                    RepresentationVindicationCosts = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    NationalIdentificationNumber = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    FinancialStateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agreements_FinancialStates_FinancialStateId",
                        column: x => x.FinancialStateId,
                        principalTable: "FinancialStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agreements_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_FinancialStateId",
                table: "Agreements",
                column: "FinancialStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_PersonId",
                table: "Agreements",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_People_AddressId",
                table: "People",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "FinancialStates");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
