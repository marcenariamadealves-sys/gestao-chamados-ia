# Gestão de Chamados (Marcenaria Madealves)

Resumo
Sistema integrado para gestão de chamados e suporte técnico com recursos de IA (simulação). Desenvolvido como PIM IV — UNIP 2025/2.

Tecnologias principais
- Backend/API: ASP.NET 6 (C#)
- Web: ASP.NET MVC (C#)
- Desktop: C# (Windows Forms)
- Mobile: Java (Android Studio)
- Banco de dados: MS SQL Server
- Controle de versão: Git / GitHub

Estrutura do repositório
- /backend/  — API REST (GestaoChamadosAPI)
- /web/      — Aplicação web (Views, Controllers)
- /desktop/  — Aplicativo desktop (Windows Forms)
- /mobile/   — Projeto Android (Java)
- /banco de dados/ — Scripts SQL (create, insert, procedures)
- /docs/     — Documentação técnica e manuais

Execução rápida (essencial)
1. Banco de dados
   - Executar scripts em `/banco de dados/`:
     - create_database.sql
     - insert_data.sql
     - procedures.sql
   - String de conexão padrão de exemplo:
     `Server=localhost;Database=GestaoChamados;Trusted_Connection=True;`

2. Backend (API)
   - Abra `backend/GestaoChamadosAPI.sln` ou `backend/GestaoChamadosAPI.csproj` no Visual Studio.
   - Configure a string de conexão se necessário e execute o projeto.

3. Web
   - Abra `web/GestaoChamadosWeb.sln` no Visual Studio.
   - Ajuste `appsettings.json` para apontar à API/banco e execute.

4. Desktop
   - Abra `desktop/GestaoChamadosDesktop.sln` no Visual Studio.
   - Configure a conexão ao banco e execute.

5. Mobile
   - Abra o diretório `mobile/` no Android Studio.
   - Ajuste o endpoint da API e execute no emulador ou dispositivo.

Documentação e suporte
- Documentação técnica: `/docs/DOCUMENTACAO_TECNICA.md`
- Manual do usuário: `/docs/MANUAL_DO_USUARIO.md`
- Contato: marcenariamadealves@gmail.com

Licença
- Ver arquivo `LICENSE` no repositório.
