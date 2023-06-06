using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularAuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chatinteractions",
                columns: table => new
                {
                    Cinteraction_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Massage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chatinteractions", x => x.Cinteraction_Id);
                    table.ForeignKey(
                        name: "FK_Chatinteractions_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "RBooks",
                columns: table => new
                {
                    RBook_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Modified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RBooks", x => x.RBook_Id);
                    table.ForeignKey(
                        name: "FK_RBooks_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "SearchQuery",
                columns: table => new
                {
                    SQuery_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchQuery", x => x.SQuery_Id);
                    table.ForeignKey(
                        name: "FK_SearchQuery_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "User_Id");
                });

            migrationBuilder.CreateTable(
                name: "Legalinfo",
                columns: table => new
                {
                    Legalinfo_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dateadded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rbook_Id = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalinfo", x => x.Legalinfo_Id);
                    table.ForeignKey(
                        name: "FK_Legalinfo_RBooks_Id",
                        column: x => x.Id,
                        principalTable: "RBooks",
                        principalColumn: "RBook_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chatinteractions_Id",
                table: "Chatinteractions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Legalinfo_Id",
                table: "Legalinfo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RBooks_Id",
                table: "RBooks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SearchQuery_Id",
                table: "SearchQuery",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chatinteractions");

            migrationBuilder.DropTable(
                name: "Legalinfo");

            migrationBuilder.DropTable(
                name: "SearchQuery");

            migrationBuilder.DropTable(
                name: "RBooks");
        }
    }
}
