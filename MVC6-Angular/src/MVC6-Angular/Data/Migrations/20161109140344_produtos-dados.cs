using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Angle_MVC6_Angular_Seed.Data.Migrations
{
    public partial class produtosdados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('teste', 'teste desc', 8, getdate());");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
