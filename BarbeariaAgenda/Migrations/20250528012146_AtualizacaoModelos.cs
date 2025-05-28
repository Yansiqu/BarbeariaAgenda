using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarbeariaAgenda.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Barbeiros_BarbeiroId",
                table: "Agendamentos");

            migrationBuilder.AlterColumn<int>(
                name: "BarbeiroId",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Barbeiros_BarbeiroId",
                table: "Agendamentos",
                column: "BarbeiroId",
                principalTable: "Barbeiros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Barbeiros_BarbeiroId",
                table: "Agendamentos");

            migrationBuilder.AlterColumn<int>(
                name: "BarbeiroId",
                table: "Agendamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Barbeiros_BarbeiroId",
                table: "Agendamentos",
                column: "BarbeiroId",
                principalTable: "Barbeiros",
                principalColumn: "Id");
        }
    }
}
