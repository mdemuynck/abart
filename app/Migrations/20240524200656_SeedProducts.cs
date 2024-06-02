using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Price) VALUES ('Coca Cola', 1.5)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price) VALUES ('Water', 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price) VALUES ('Sprite', 1.5)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price) VALUES ('Beer', 2)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Price) VALUES ('Wine', 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
