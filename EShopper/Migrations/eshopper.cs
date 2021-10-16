using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopper.Migrations
{
    public partial class EShopper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Kg = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NumberOfPacket = table.Column<string>(nullable: true),
                    VegetableId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
            table.PrimaryKey("PK_Seeds", x => x.Id);
            table.ForeignKey(
                name: "FK_Seeds_Vegetables_VegetableId",
                column: x => x.VegetableId,
                principalTable: "Vegetables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        });


            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Kg = table.Column<string>(nullable: true),
                    DeliveryAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seeds");

            migrationBuilder.DropTable(
                name: "Vegetables");

            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
