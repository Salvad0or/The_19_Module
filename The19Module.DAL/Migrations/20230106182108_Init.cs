using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The19Module.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Patronymic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Person");
        }
    }
}
