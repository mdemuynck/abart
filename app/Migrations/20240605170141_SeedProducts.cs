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
            migrationBuilder.Sql("INSERT INTO Products (Name, ProductPrice, UnitPrice) VALUES ('Water', 10.0, 2.0)");
            migrationBuilder.Sql("INSERT INTO Products (Name, ProductPrice, UnitPrice) VALUES ('Fanta', 20.0, 4.0)");
            migrationBuilder.Sql("INSERT INTO Products (Name, ProductPrice, UnitPrice) VALUES ('Cola', 30.0, 6.0)");
            migrationBuilder.Sql("INSERT INTO Products (Name, ProductPrice, UnitPrice) VALUES ('Chips', 40.0, 8.0)");
            migrationBuilder.Sql("INSERT INTO Products (Name, ProductPrice, UnitPrice) VALUES ('Pintje', 50.0, 10.0)");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
