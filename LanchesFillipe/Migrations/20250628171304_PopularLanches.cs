using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesFillipe.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1 – Cheese Salada (Categoria: Normais)
            migrationBuilder.Sql(
                "INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemURL, IsLanchePreferido, Nome, Preco) " +
                "VALUES (1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', " +
                "'Delicioso pão de hambúrguer com ovo, presunto e queijo de primeira qualidade, acompanhado com batata palha.', 1, " +
                "'https://images.unsplash.com/photo-1586190848861-99aa4a171e90?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwyNzY4ODB8MHwxfHNlYXJjaHwxfHxjaGVlc2VidXJnZXJ8ZW58MHx8fHwxNjg4MTI3MjQw&ixlib=rb-1.2.1&q=80&w=400', " +
                "'https://images.unsplash.com/photo-1586190848861-99aa4a171e90?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwyNzY4ODB8MHwxfHNlYXJjaHwxfHxjaGVlc2VidXJnZXJ8ZW58MHx8fHwxNjg4MTI3MjQw&ixlib=rb-1.2.1&q=80&w=1200', 0, 'Cheese Salada', 12.50)"
            );

            // 2 - Frango Fit (Categoria: Natural)
            migrationBuilder.Sql(
                "INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemURL, IsLanchePreferido, Nome, Preco) " +
                "VALUES (2, 'Pão integral com peito de frango grelhado, alface e tomate', 'Uma opção leve e saudável com frango grelhado e vegetais frescos.', 1, " +
                "'https://www.receiteria.com.br/wp-content/uploads/sanduiche-natural-de-frango.jpg', " +
                "'https://www.receiteria.com.br/wp-content/uploads/sanduiche-natural-de-frango.jpg', 1, 'Frango Fit', 15.90)"
            );


            // 3 – Cheddar Burger (Categoria: Normais)
            migrationBuilder.Sql(
                "INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemURL, IsLanchePreferido, Nome, Preco) " +
                "VALUES (1, 'Pão brioche, carne bovina artesanal e queijo cheddar', " +
                "'Hambúrguer artesanal com carne suculenta e muito cheddar derretido no pão brioche.', 1, " +
                "'https://cdn.pixabay.com/photo/2016/03/05/19/02/hamburger-1238246_640.jpg', " +
                "'https://cdn.pixabay.com/photo/2016/03/05/19/02/hamburger-1238246_1280.jpg', 1, 'Cheddar Burger', 18.00)"
            );
        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
