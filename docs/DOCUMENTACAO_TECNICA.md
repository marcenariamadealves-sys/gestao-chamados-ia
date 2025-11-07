MANUAL TÉCNICO — Sistema de Gestão de Chamados e Suporte Técnico com IA
1. Visão Geral

O sistema foi desenvolvido para centralizar o controle de chamados técnicos da Marcenaria Madealves, permitindo o registro, acompanhamento e encerramento de solicitações de suporte.

O projeto é composto por quatro módulos integrados:

Aplicativo Desktop: uso interno por atendentes e administradores.

Aplicativo Web: acesso via navegador.

Aplicativo Mobile: uso por técnicos em campo (Android).

Backend/API: comunicação entre os módulos e o banco de dados SQL Server.

2. Tecnologias Utilizadas
Camada	Tecnologia
Backend/API	ASP.NET 6 + C#
Banco de Dados	Microsoft SQL Server
Desktop	C# + Windows Forms
Web	ASP.NET MVC (C#)
Mobile	Java + Android Studio
Controle de Versão	Git + GitHub
3. Estrutura de Diretórios
/desktop/ → Aplicativo Desktop (Windows Forms)
    /Models/ → Classes e controladores

/web/ → Aplicativo Web (ASP.NET MVC)
    /Views/ → Telas do sistema

/backend/ → API REST (ASP.NET)
    /Controllers/ → Endpoints da API
    /Models/ → Entidades de dados
    /Services/ → Lógica de negócio

/mobile/ → Aplicativo Android (Java)

/banco de dados/ → Scripts SQL de criação e carga de dados

/docs/ → Relatórios, manuais e documentação técnica

4. Banco de Dados

Os scripts SQL estão localizados na pasta /banco de dados/:

create_database.sql — Criação do banco e tabelas.

insert_data.sql — Dados de exemplo.

procedures.sql — Procedures de controle de chamados e usuários.

Conexão padrão:

Server=localhost;Database=GestaoChamados;Trusted_Connection=True;

5. API (Backend)

A GestaoChamadosAPI fornece endpoints REST para integração entre os módulos.

Método	Endpoint	Descrição
GET	/api/chamados	Lista todos os chamados
GET	/api/chamados/{id}	Detalha um chamado específico
POST	/api/chamados	Cria novo chamado
PUT	/api/chamados/{id}	Atualiza um chamado existente
DELETE	/api/chamados/{id}	Exclui um chamado

A API utiliza ChamadoService e o modelo Chamado.cs para comunicação com o banco.

6. Aplicativo Desktop

Desenvolvido em C# (Windows Forms), voltado ao uso interno.

Principais telas:

FrmLogin — Autenticação.

FrmDashboard — Gerenciamento e visualização de chamados.

ChamadoController — Conexão entre a interface e a API.

Execução:
Abra GestaoChamadosDesktop.sln no Visual Studio e configure a conexão SQL.

7. Aplicativo Web

Desenvolvido em ASP.NET MVC (C#), é responsivo e acessível via navegador.

Views principais:

Login.cshtml

Dashboard.cshtml

Formulario.cshtml

Acompanhamento.cshtml

PerguntasFrequentes/Index.cshtml

Execução:
Abra GestaoChamadosWeb.sln e configure o arquivo appsettings.json com a string de conexão.

8. Aplicativo Mobile

Criado em Java (Android Studio), destinado a técnicos em campo.

Arquivos principais:

MainActivity.java — Tela principal.

activity_main.xml — Layout principal.

AndroidManifest.xml — Configurações do app.

build.gradle — Dependências.

proguard-rules.pro — Regras de otimização.

Build:
Abra o projeto no Android Studio, conecte o celular e execute.

9. Integração com IA

O sistema possui integração simulada com ChatGPT, usada para:

FAQ automatizada.

Sugestões de solução baseadas em histórico de chamados.

Apoio no atendimento com respostas inteligentes.

10. Execução Completa

Execute os scripts SQL para criar o banco de dados.

Inicie a API (GestaoChamadosAPI).

Execute a versão Desktop, Web ou Mobile.

Teste cadastros, consultas e relatórios.

11. Equipe do Projeto
Integrante	Função
Kauan Luiz	Líder / Integração
Enzo Ferrari	Backend e Banco de Dados
Lucas Vieira	Mobile e QA
12. Contato

marcenariamadealves@gmail.com

Documento técnico — PIM IV (UNIP 2025/2)
Projeto: Sistema Integrado de Gestão de Chamados com IA
