﻿// <auto-generated />
using System;
using ExcellImportData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcellImportData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240715113655_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExcellImportData.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ACAPAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvisorAnnualFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateInvestmentsAccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternateInvestmentsIsPresent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContraAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("InvestmentObjective")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiquidityNeedsIsPresent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiquidityNeedsType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Margin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("NewCustodian")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionsTrading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RegistrationTypeAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StandingInstructionsNumber")
                        .HasColumnType("int");

                    b.Property<string>("SubadvisorStrategy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyCollateralAccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPartyCollateralAccountIsPresent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeHorizon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionCharges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZeroBalCALAccount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("ExcellImportData.Models.AchEftInstructions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AchEftInstructions");
                });

            modelBuilder.Entity("ExcellImportData.Models.BeneficiariesFor529", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustodianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustodianId");

                    b.ToTable("BeneficiariesFor529");
                });

            modelBuilder.Entity("ExcellImportData.Models.BeneficiariesForRetirement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BeneficiaryPercentage")
                        .HasColumnType("float");

                    b.Property<Guid>("CustodianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealationShip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustodianId");

                    b.ToTable("BeneficiariesForRetirements");
                });

            modelBuilder.Entity("ExcellImportData.Models.Custodian", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AffiliatedPrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CitizenshipStatusPrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControlPublic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EveningPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SSNTINCheckbox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceOfWealth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SsnTin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCLegalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCRelationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Custodians");
                });

            modelBuilder.Entity("ExcellImportData.Models.HouseholdPreferences", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountAccessRights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DividendReinvestment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NonRetirementMoneyMarket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RetirementMoneyMarket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatementPrefences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeConfirmation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HouseholdPreferences");
                });

            modelBuilder.Entity("ExcellImportData.Models.HouseholdSuitabilityInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnnualIncome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientTaxBracket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiquidNetWorth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetWorth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HouseholdSuitabilityInformations");
                });

            modelBuilder.Entity("ExcellImportData.Models.Individual", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Authority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IndividualName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TrustId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TrustId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("ExcellImportData.Models.Instructions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AchEftInstructionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountRegristration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankRouting")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AchEftInstructionsId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("ExcellImportData.Models.OriginalDepositor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustodianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("DOD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustodianId");

                    b.ToTable("originalDepositors");
                });

            modelBuilder.Entity("ExcellImportData.Models.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AchEftInstructionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HouseholdDeliveryPreference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HouseholdPreferencesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HouseholdSuitabilityInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AchEftInstructionsId");

                    b.HasIndex("HouseholdPreferencesId");

                    b.HasIndex("HouseholdSuitabilityInformationId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("ExcellImportData.Models.Trust", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EstablishedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullTrustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsRevocable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SSNTIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSNTINType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateOfEstablishment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TrustDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.ToTable("Trusts");
                });

            modelBuilder.Entity("ExcellImportData.Models.Account", b =>
                {
                    b.HasOne("ExcellImportData.Models.Record", "Record")
                        .WithMany("Accounts")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("ExcellImportData.Models.BeneficiariesFor529", b =>
                {
                    b.HasOne("ExcellImportData.Models.Custodian", "Custodian")
                        .WithMany("BeneficiariesFor529")
                        .HasForeignKey("CustodianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Custodian");
                });

            modelBuilder.Entity("ExcellImportData.Models.BeneficiariesForRetirement", b =>
                {
                    b.HasOne("ExcellImportData.Models.Custodian", "Custodian")
                        .WithMany("BeneficiariesForRetirement")
                        .HasForeignKey("CustodianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Custodian");
                });

            modelBuilder.Entity("ExcellImportData.Models.Custodian", b =>
                {
                    b.HasOne("ExcellImportData.Models.Record", "Record")
                        .WithMany("Custodians")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("ExcellImportData.Models.Individual", b =>
                {
                    b.HasOne("ExcellImportData.Models.Trust", "Trust")
                        .WithMany("Individuals")
                        .HasForeignKey("TrustId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trust");
                });

            modelBuilder.Entity("ExcellImportData.Models.Instructions", b =>
                {
                    b.HasOne("ExcellImportData.Models.AchEftInstructions", "AchEftInstructions")
                        .WithMany("Instructions")
                        .HasForeignKey("AchEftInstructionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AchEftInstructions");
                });

            modelBuilder.Entity("ExcellImportData.Models.OriginalDepositor", b =>
                {
                    b.HasOne("ExcellImportData.Models.Custodian", "Custodian")
                        .WithMany("OriginalDepositor")
                        .HasForeignKey("CustodianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Custodian");
                });

            modelBuilder.Entity("ExcellImportData.Models.Record", b =>
                {
                    b.HasOne("ExcellImportData.Models.AchEftInstructions", "AchEftInstructions")
                        .WithMany()
                        .HasForeignKey("AchEftInstructionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExcellImportData.Models.HouseholdPreferences", "HouseholdPreferences")
                        .WithMany()
                        .HasForeignKey("HouseholdPreferencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExcellImportData.Models.HouseholdSuitabilityInformation", "HouseholdSuitabilityInformation")
                        .WithMany()
                        .HasForeignKey("HouseholdSuitabilityInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AchEftInstructions");

                    b.Navigation("HouseholdPreferences");

                    b.Navigation("HouseholdSuitabilityInformation");
                });

            modelBuilder.Entity("ExcellImportData.Models.Trust", b =>
                {
                    b.HasOne("ExcellImportData.Models.Record", "Record")
                        .WithMany("Trusts")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("ExcellImportData.Models.AchEftInstructions", b =>
                {
                    b.Navigation("Instructions");
                });

            modelBuilder.Entity("ExcellImportData.Models.Custodian", b =>
                {
                    b.Navigation("BeneficiariesFor529");

                    b.Navigation("BeneficiariesForRetirement");

                    b.Navigation("OriginalDepositor");
                });

            modelBuilder.Entity("ExcellImportData.Models.Record", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Custodians");

                    b.Navigation("Trusts");
                });

            modelBuilder.Entity("ExcellImportData.Models.Trust", b =>
                {
                    b.Navigation("Individuals");
                });
#pragma warning restore 612, 618
        }
    }
}
