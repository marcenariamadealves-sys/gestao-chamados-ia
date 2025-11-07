# Sistema Integrado de Gestão de Chamados e Suporte Técnico com IA

Este projeto foi desenvolvido como parte do **PIM IV** do curso de **Análise e Desenvolvimento de Sistemas (UNIP - 2025/2)**, com o objetivo de criar um sistema inteligente de **gestão de chamados de suporte técnico** que utiliza **Inteligência Artificial** para otimizar atendimentos e gerar FAQs dinâmicas.

---

## Objetivo Geral
Desenvolver um sistema integrado (Desktop, Web e Mobile) para o controle de chamados e suporte técnico, com recursos de automação, relatórios, histórico de atendimentos e integração com IA generativa.

---

## Arquitetura Geral
- **Frontend Desktop:** C# (Windows Forms/WPF)  
- **Frontend Web:** ASP.NET MVC (C#)  
- **Frontend Mobile:** Java + Android Studio  
- **Backend:** ASP.NET + Web API  
- **Banco de Dados:** Microsoft SQL Server  
- **IA Generativa:** ChatGPT (simulações de FAQ dinâmica)  
- **Controle de Versão:** Git + GitHub

---

## Instalação e Execução

### 1) Banco de Dados
1. Instale o **SQL Server**.
2. Execute os scripts da pasta `/database/`:
   - `create_database.sql`
   - `insert_data.sql`
   - `procedures.sql`

### 2) Aplicação Web
1. Abra `/web/GestaoChamadosWeb.sln` no **Visual Studio**.
2. Configure a **connection string** no `appsettings.json`.
3. Execute o projeto.

### 3) Aplicação Desktop
1. Abra `/desktop/GestaoChamadosDesktop.sln` no Visual Studio.
2. Configure a conexão com o SQL Server.
3. Execute o aplicativo.

### 4) Aplicativo Mobile
1. Abra `/mobile/` no **Android Studio**.
2. Execute em emulador/dispositivo.
3. O app consome a **API REST** do backend.

---

## Principais Funcionalidades
- Cadastro e acompanhamento de chamados.  
- FAQ dinâmica com base no histórico.  
- Dashboards administrativos e relatórios.  
- Controle de usuários e permissões.  
- Conformidade com a **LGPD**.

---

## Uso de Inteligência Artificial
- Sugestões automáticas de resposta.  
- Geração de conteúdo para a FAQ.  
- Apoio à documentação técnica.

---

## Documentação
Arquivos na pasta `/docs/`:
- Manual do Usuário  
- Diagramas UML e MER  
- Plano de Homologação  
- Relatórios de Testes  
- Apresentação em PowerPoint

---

## Equipe
| Integrante | Função |
|------------|--------|
| Kauan Luiz | Líder / Integrador |
| Enzo Ferrari | Backend / DB |
| Lucas Vieira | Mobile / QA |

---

## Versionamento
Branching: `main` (estável) / `develop` / `feature/*` / `hotfix/*`

---

## Contato
marcenariamadealves@gmail.com
