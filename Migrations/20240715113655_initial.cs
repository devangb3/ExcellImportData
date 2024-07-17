using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcellImportData.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AchEftInstructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchEftInstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountAccessRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatementPrefences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeConfirmation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DividendReinvestment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetirementMoneyMarket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonRetirementMoneyMarket = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdPreferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdSuitabilityInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnnualIncome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NetWorth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiquidNetWorth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientTaxBracket = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdSuitabilityInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountRegristration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankRouting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchEftInstructionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_AchEftInstructions_AchEftInstructionsId",
                        column: x => x.AchEftInstructionsId,
                        principalTable: "AchEftInstructions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseholdDeliveryPreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchEftInstructionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseholdSuitabilityInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseholdPreferencesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_AchEftInstructions_AchEftInstructionsId",
                        column: x => x.AchEftInstructionsId,
                        principalTable: "AchEftInstructions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_HouseholdPreferences_HouseholdPreferencesId",
                        column: x => x.HouseholdPreferencesId,
                        principalTable: "HouseholdPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_HouseholdSuitabilityInformations_HouseholdSuitabilityInformationId",
                        column: x => x.HouseholdSuitabilityInformationId,
                        principalTable: "HouseholdSuitabilityInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationTypeAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContraAccountNumber = table.Column<int>(type: "int", nullable: false),
                    NewAccountNumber = table.Column<int>(type: "int", nullable: false),
                    NewCustodian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionCharges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvisorAnnualFee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestmentObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeHorizon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiquidityNeedsIsPresent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiquidityNeedsType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandingInstructionsNumber = table.Column<int>(type: "int", nullable: false),
                    Margin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateInvestmentsIsPresent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlternateInvestmentsAccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ACAPAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZeroBalCALAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPartyCollateralAccountIsPresent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPartyCollateralAccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionsTrading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubadvisorStrategy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Custodians",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SsnTin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSNTINCheckbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CitizenshipStatusPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EveningPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegalCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceOfWealth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffiliatedPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlPublic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCRelationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCLegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custodians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Custodians_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trusts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullTrustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrustDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRevocable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateOfEstablishment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSNTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSNTINType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trusts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trusts_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiariesFor529",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustodianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiariesFor529", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeneficiariesFor529_Custodians_CustodianId",
                        column: x => x.CustodianId,
                        principalTable: "Custodians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiariesForRetirements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealationShip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPercentage = table.Column<double>(type: "float", nullable: false),
                    CustodianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiariesForRetirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeneficiariesForRetirements_Custodians_CustodianId",
                        column: x => x.CustodianId,
                        principalTable: "Custodians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "originalDepositors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustodianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_originalDepositors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_originalDepositors_Custodians_CustodianId",
                        column: x => x.CustodianId,
                        principalTable: "Custodians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndividualName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Authority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrustId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individuals_Trusts_TrustId",
                        column: x => x.TrustId,
                        principalTable: "Trusts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_RecordId",
                table: "Accounts",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiariesFor529_CustodianId",
                table: "BeneficiariesFor529",
                column: "CustodianId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiariesForRetirements_CustodianId",
                table: "BeneficiariesForRetirements",
                column: "CustodianId");

            migrationBuilder.CreateIndex(
                name: "IX_Custodians_RecordId",
                table: "Custodians",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_TrustId",
                table: "Individuals",
                column: "TrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_AchEftInstructionsId",
                table: "Instructions",
                column: "AchEftInstructionsId");

            migrationBuilder.CreateIndex(
                name: "IX_originalDepositors_CustodianId",
                table: "originalDepositors",
                column: "CustodianId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_AchEftInstructionsId",
                table: "Records",
                column: "AchEftInstructionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_HouseholdPreferencesId",
                table: "Records",
                column: "HouseholdPreferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_HouseholdSuitabilityInformationId",
                table: "Records",
                column: "HouseholdSuitabilityInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Trusts_RecordId",
                table: "Trusts",
                column: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "BeneficiariesFor529");

            migrationBuilder.DropTable(
                name: "BeneficiariesForRetirements");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "originalDepositors");

            migrationBuilder.DropTable(
                name: "Trusts");

            migrationBuilder.DropTable(
                name: "Custodians");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "AchEftInstructions");

            migrationBuilder.DropTable(
                name: "HouseholdPreferences");

            migrationBuilder.DropTable(
                name: "HouseholdSuitabilityInformations");
        }
    }
}
