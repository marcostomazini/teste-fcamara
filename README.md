Apresentacao: https://youtu.be/mv2PTCXAXYY

Source code: https://github.com/marcostomazini/teste-fcamara

Geracao do token: /wcf/Services/AuthenticationTokenService.svc/GenerateToken
Metodo: GET
Retorno: Guid com tempo de expiração de 1 minuto

Validacao do token: /wcf/Services/AuthenticationTokenService.svc/ValidateToken
Metodo: GET + HEADERS - Token: valor
Retorno: true - valido / false - invalido

Alterações em web.config do wcf para habilitar autenticacao e servicos restfull;

wcf/Negocios - Geracao de token, Validacao de token e conferencia de credencial.
wcf/Services - Classes e interfaces que expoe os servicos externamente: GenerateToken/ValidateToken

Dotnet core:
wwwroot\master\js\custom: Regra e ações do frontend para exibir mensagem de validacao e countdown de expiracao do token.
Views\Produto: View do Produtos
Data\Migrations: Classe do migrations para criacao da tabela e insercao de dados
Controllers\ProdutoController.cs: Metodos webapi e mvc para expor os servicos de busca produtos.
Repositorio\ProdutoRepositorio.cs: Repositorio que retorna os dados contidos na tabela via orm ef6.
Models\ProdutoModels\Produto.cs: Entidade do produto no orm ef6 (tabela produto no sqlserver)
Security\AuthorizationLab.cs: Validacao do token na webapi para nao expor os dados sem seguranca.
Startup.cs: Registros de injecao de depencia do repositorio, contexto, ativacao do mvc, configuracao de classe singletons, ativacao do cors, ativacao da telemetria.
