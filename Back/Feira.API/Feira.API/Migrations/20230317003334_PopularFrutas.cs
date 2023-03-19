using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feira.API.Migrations
{
    public partial class PopularFrutas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Frutas(Fruta, ValorA, ValorB) " +
                "VALUES('Banana', 10, 2)");
            migrationBuilder.Sql("INSERT INTO Frutas(Fruta, ValorA, ValorB) " +
                "VALUES('Maça', 2, 5)");
            migrationBuilder.Sql("INSERT INTO Frutas(Fruta, ValorA, ValorB) " +
                "VALUES('Uva', 20, 10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
