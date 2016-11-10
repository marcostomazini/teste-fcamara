using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Angle_MVC6_Angular_Seed.Data.Migrations
{
    public partial class produtosdados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('produto teste', 'teste desc', 8, getdate());");
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('produto teste 2', 'teste desc 123', 8, getdate());");
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('produto teste 3', 'teste desc 321', 7, getdate());");
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('produto teste 4', 'teste desc 987', 3, getdate());");
            migrationBuilder.Sql(@"insert into Produtos (nome,descricao,preco,datainclusao) VALUES ('produto teste 5', 'teste desc 976', 2, getdate());");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
