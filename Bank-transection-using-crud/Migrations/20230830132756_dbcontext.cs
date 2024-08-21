using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_transection_using_crud.Migrations
{
    public partial class dbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transections",
                columns: table => new
                {
                    Transectionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accountnumber = table.Column<string>(type: "varchar(100)", nullable: false),
                    Beneficiaryname = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bankname = table.Column<string>(type: "varchar(100)", nullable: false),
                    Swiftcode = table.Column<string>(type: "varchar(100)", nullable: false),
                    Amount = table.Column<string>(type: "varchar(100)", nullable: false),
                    Date = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transections", x => x.Transectionid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transections");
        }
    }
}
