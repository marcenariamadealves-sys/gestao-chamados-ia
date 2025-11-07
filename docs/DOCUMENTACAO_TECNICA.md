# Documentação Técnica — Sistema de Gestão de Chamados e Suporte Técnico com IA

## 1. Visão Geral
O sistema foi desenvolvido para centralizar o controle de chamados técnicos da **Marcenaria Madealves**, permitindo o registro, acompanhamento e encerramento de solicitações de suporte.

O projeto é composto por **quatro módulos integrados**:
- **Aplicativo Desktop:** voltado ao uso interno dos atendentes e administradores.  
- **Aplicativo Web:** acesso via navegador, ideal para colaboradores remotos.  
- **Aplicativo Mobile (Android):** acesso rápido em campo para técnicos.  
- **Backend/API:** comunicação central entre os módulos e o banco de dados SQL Server.

---

## 2. Tecnologias Utilizadas

| Camada | Tecnologia |
|---------|-------------|
| Backend/API | ASP.NET 6 + C# |
| Banco de Dados | Microsoft SQL Server |
| Desktop | C# + Windows Forms |
| Web | ASP.NET MVC (C#) |
| Mobile | Java + Android Studio |
| Controle de Versão | Git + GitHub |

---

## 3. Estrutura de Diretórios

/desktop/ → Aplicativo Desktop (Windows Forms)
/Modelos/ → Classes e controladores

/web/ → Aplicativo Web (ASP.NET MVC)
/Views/ → Telas do sistema

/backend/ → API REST (ASP.NET)
/Controllers/ → Endpoints da API
/Models/ → Entidades de dados
/Services/ → Lógica de negócio

/móvel/ → Aplicativo Android (Java)

/banco de dados/ → Scripts SQL de criação e carga de dados

/documentos/ → Relatórios, manuais e documentação técnica


---

## 4. Banco de Dados

Os scripts estão na pasta `/banco de dados/`:
- `create_database.sql` → Criação do banco e tabelas  
- `insert_data.sql` → Dados de exemplo  
- `procedures.sql` → Procedures para controle de chamados e usuários  

**Conexão padrão:**

Server=localhost;Database=GestaoChamados;Trusted_Connection=True;


---

## 5. API (Backend)

A **GestaoChamadosAPI** fornece endpoints REST para integração entre os sistemas:

| Método | Endpoint | Descrição |
|---------|-----------|------------|
| GET | /api/chamados | Lista todos os chamados |
| GET | /api/chamados/{id} | Detalha um chamado |
| POST | /api/chamados | Cria novo chamado |
| PUT | /api/chamados/{id} | Atualiza um chamado existente |
| DELETE | /api/chamados/{id} | Exclui um chamado |

A API utiliza o serviço `ChamadoService` e o modelo `Chamado.cs` para comunicação com o banco de dados.

---

## 6. Aplicativo Desktop

Desenvolvido em **C# (Windows Forms)**, com foco em facilidade e produtividade no atendimento técnico.

**Principais telas:**
- `FrmLogin` → autenticação do usuário.  
- `FrmDashboard` → visão geral dos chamados e status.  
- `ChamadoController` → lógica de controle entre interface e API.  

**Execução:**  
Abra `GestaoChamadosDesktop.sln` no **Visual Studio** e configure a conexão SQL.

---

## 7. Aplicativo Web

Desenvolvido em **ASP.NET MVC (C#)**, responsivo e acessível via qualquer navegador moderno.

**Principais views:**
- `Login.cshtml` → Tela de login.  
- `Dashboard.cshtml` → Painel principal.  
- `Formulario.cshtml` → Registro de chamados.  
- `Acompanhamento.cshtml` → Monitoramento de chamados.  
- `PerguntasFrequentes/Index.cshtml` → Página de FAQ.  

**Execução:**  
Abra `GestaoChamadosWeb.sln` e ajuste a string de conexão no arquivo `appsettings.json`.

---

## 8. Aplicativo Mobile

Criado em **Java (Android Studio)**, projetado para técnicos e colaboradores em campo.

**Principais arquivos:**
- `MainActivity.java` → Tela principal do app.  
- `activity_main.xml` → Layout principal.  
- `AndroidManifest.xml` → Configurações do aplicativo.  
- `build.gradle` → Dependências do projeto.  
- `proguard-rules.pro` → Regras de otimização e segurança.  

**Build:**  
Execute via **Android Studio**, conectando à API REST para sincronização de chamados.

---

## 9. Integração com IA

O sistema possui integração simulada com **ChatGPT**, aplicada para:
- Respostas automáticas em FAQ.  
- Sugestões de solução baseadas em histórico de chamados.  
- Apoio ao atendimento com respostas rápidas e contexto técnico.

---

## 10. Execução Completa

1. Execute o script SQL para criar o banco de dados.  
2. Inicie o **Backend (GestaoChamadosAPI)**.  
3. Abra o **Desktop**, **Web** ou **Mobile** e conecte à API.  
4. Teste cadastros, consultas e relatórios.  

---

## 11. Equipe do Projeto

| Integrante | Função |
|-------------|--------|
| Kauan Luiz | Líder / Integração |
| Enzo Ferrari | Backend e Banco de Dados |
| Lucas Vieira | Mobile e QA |

---

## 12. Contato

**marcenariamadealves@gmail.com**

---

> **Documento técnico — PIM IV (UNIP 2025/2)**  
> Projeto: *Sistema Integrado de Gestão de Chamados com IA*


