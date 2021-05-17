﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DatabaseTier.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTable",
                columns: table => new
                {
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Balance = table.Column<double>(type: "double precision", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTable", x => x.AccountNumber);
                });

            migrationBuilder.CreateTable(
                name: "CityTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ZipCode = table.Column<int>(type: "integer", nullable: false),
                    CityName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersTable",
                columns: table => new
                {
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTable", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTable",
                columns: table => new
                {
                    TransactionNumber = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderAccountNumber = table.Column<long>(type: "bigint", nullable: true),
                    ReceiverAccountNumber = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Save = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTable", x => x.TransactionNumber);
                    table.ForeignKey(
                        name: "FK_TransactionTable_AccountTable_ReceiverAccountNumber",
                        column: x => x.ReceiverAccountNumber,
                        principalTable: "AccountTable",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransactionTable_AccountTable_SenderAccountNumber",
                        column: x => x.SenderAccountNumber,
                        principalTable: "AccountTable",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AddressTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StreetName = table.Column<string>(type: "text", nullable: true),
                    StreetNumber = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressTable_CityTable_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomersTable",
                columns: table => new
                {
                    CprNumber = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    CountryOfResidence = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersTable", x => x.CprNumber);
                    table.ForeignKey(
                        name: "FK_CustomersTable_AddressTable_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomersTable_UsersTable_Username",
                        column: x => x.Username,
                        principalTable: "UsersTable",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SavedAccountsTable",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SaveAccountAccountNumber = table.Column<long>(type: "bigint", nullable: true),
                    AccountName = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    CustomerCprNumber = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedAccountsTable", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_SavedAccountsTable_AccountTable_SaveAccountAccountNumber",
                        column: x => x.SaveAccountAccountNumber,
                        principalTable: "AccountTable",
                        principalColumn: "AccountNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedAccountsTable_CustomersTable_CustomerCprNumber",
                        column: x => x.CustomerCprNumber,
                        principalTable: "CustomersTable",
                        principalColumn: "CprNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressTable_CityId",
                table: "AddressTable",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersTable_AddressId",
                table: "CustomersTable",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersTable_Username",
                table: "CustomersTable",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAccountsTable_CustomerCprNumber",
                table: "SavedAccountsTable",
                column: "CustomerCprNumber");

            migrationBuilder.CreateIndex(
                name: "IX_SavedAccountsTable_SaveAccountAccountNumber",
                table: "SavedAccountsTable",
                column: "SaveAccountAccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTable_ReceiverAccountNumber",
                table: "TransactionTable",
                column: "ReceiverAccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionTable_SenderAccountNumber",
                table: "TransactionTable",
                column: "SenderAccountNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedAccountsTable");

            migrationBuilder.DropTable(
                name: "TransactionTable");

            migrationBuilder.DropTable(
                name: "CustomersTable");

            migrationBuilder.DropTable(
                name: "AccountTable");

            migrationBuilder.DropTable(
                name: "AddressTable");

            migrationBuilder.DropTable(
                name: "UsersTable");

            migrationBuilder.DropTable(
                name: "CityTable");
        }
    }
}