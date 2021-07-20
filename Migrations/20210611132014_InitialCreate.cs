using Microsoft.EntityFrameworkCore.Migrations;

namespace AirLineAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detailtickets",
                columns: table => new
                {
                    Ticket_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Flight_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemainAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailtickets", x => x.Ticket_ID);
                });

            migrationBuilder.CreateTable(
                name: "FlightRoutes",
                columns: table => new
                {
                    Route_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightRoutes", x => x.Route_ID);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Flight_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Route_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plane_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Flight_ID);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Note_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Staff_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckMaster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckStation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Note_ID);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    Plane_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlaneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaneManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaneSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FistClassSeats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondClassSeats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Plane_ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketsSolds",
                columns: table => new
                {
                    Ticket_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Bill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Staff_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flight_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketsSolds", x => x.Ticket_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detailtickets");

            migrationBuilder.DropTable(
                name: "FlightRoutes");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "TicketsSolds");
        }
    }
}
