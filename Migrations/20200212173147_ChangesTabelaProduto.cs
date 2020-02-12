using Microsoft.EntityFrameworkCore.Migrations;

namespace School_of_net_MVC.Migrations
{
    public partial class ChangesTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "NovoNomeDaTabela");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "NovoNomeDaTabela",
                newName: "IX_NovoNomeDaTabela_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "NovoNomeDaTabela",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NovoNomeDaTabela",
                table: "NovoNomeDaTabela",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NovoNomeDaTabela_Categorias_CategoriaId",
                table: "NovoNomeDaTabela",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NovoNomeDaTabela_Categorias_CategoriaId",
                table: "NovoNomeDaTabela");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NovoNomeDaTabela",
                table: "NovoNomeDaTabela");

            migrationBuilder.RenameTable(
                name: "NovoNomeDaTabela",
                newName: "Produtos");

            migrationBuilder.RenameIndex(
                name: "IX_NovoNomeDaTabela_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
