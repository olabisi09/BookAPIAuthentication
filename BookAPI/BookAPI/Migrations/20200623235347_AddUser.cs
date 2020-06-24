﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BookAPI.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "BookUsers",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   FirstName = table.Column<string>(nullable: true),
                   LastName = table.Column<string>(nullable: true),
                   Username = table.Column<string>(nullable: true),
                   Email = table.Column<string>(nullable: true),
                   PhoneNo = table.Column<string>(nullable: true),
                   PasswordHash = table.Column<byte[]>(nullable: true),
                   PasswordSalt = table.Column<byte[]>(nullable: true),
                   Dateregistered = table.Column<DateTime>(nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_BookUsers", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUsers");
        }
    }
}
