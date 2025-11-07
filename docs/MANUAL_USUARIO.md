Manual do Usuário — Sistema de Gestão de Chamados e Suporte Técnico com IA
1. Objetivo

Este manual orienta os colaboradores da Marcenaria Madealves sobre o uso do sistema de Gestão de Chamados e Suporte Técnico com IA, explicando o funcionamento básico das versões Desktop, Web e Mobile.

2. Acesso ao Sistema

Para acessar o sistema, o usuário deve informar seu login e senha fornecidos pela administração.
O sistema está disponível em três plataformas:

Desktop: uso interno pelos computadores da empresa.

Web: acesso remoto via navegador.

Mobile: uso em campo pelos técnicos (Android).

3. Versão Desktop

A versão desktop foi desenvolvida em C# (Windows Forms), com foco na praticidade para os atendentes e administradores.

Principais telas:

Login: autenticação do usuário.

Dashboard: exibe os chamados abertos, em andamento e finalizados.

Formulário de Chamado: registro de novas solicitações.

Relatórios: visualização de métricas e status.

Execução:
Abra GestaoChamadosDesktop.sln no Visual Studio, configure o banco de dados e pressione F5 para iniciar.

4. Versão Web

Desenvolvida em ASP.NET MVC (C#), a versão web é responsiva e acessível por qualquer navegador moderno.

Páginas principais:

Login.cshtml → Tela de autenticação.

Dashboard.cshtml → Painel com resumo dos chamados.

Formulario.cshtml → Registro de chamados.

Acompanhamento.cshtml → Consulta e andamento das solicitações.

PerguntasFrequentes/Index.cshtml → FAQ com suporte automatizado via IA.

Execução:
Abra GestaoChamadosWeb.sln e execute o servidor local no Visual Studio.

5. Versão Mobile

Criada em Java (Android Studio), a versão mobile foi projetada para uso pelos técnicos em campo.

Principais arquivos:

MainActivity.java → Tela principal do aplicativo.

activity_main.xml → Layout principal da interface.

AndroidManifest.xml → Configurações e permissões.

build.gradle → Dependências e build.

proguard-rules.pro → Regras de segurança e otimização.

Instalação:
Abra o projeto no Android Studio, conecte o celular (modo desenvolvedor) e clique em ▶️ Run App.

6. Integração com IA

O sistema possui integração simulada com ChatGPT, usada para:

Respostas automáticas em perguntas frequentes.

Sugestões de soluções baseadas em chamados anteriores.

Apoio inteligente no atendimento e triagem de chamados.

7. Dicas de Uso

Utilize senhas seguras e não compartilhe seu acesso.

Antes de abrir um chamado, consulte a FAQ (Perguntas Frequentes).

Verifique o status de chamados abertos no Dashboard.

Feche chamados apenas após confirmar a solução com o cliente.

8. Figuras Ilustrativas

Figura 23 — Tela de Login (Desktop)
Exibe campos de login e senha para autenticação do usuário.

Figura 24 — Tela Principal (Dashboard - Desktop)
Mostra os chamados abertos, em andamento e encerrados.

Figura 25 — Formulário de Novo Chamado (Desktop)
Permite registrar novas solicitações de suporte.

Figura 26 — Relatórios e Métricas (Desktop)
Gera relatórios com dados de desempenho e atendimento.

Figura 27 — Página de Login (Web)
Autenticação de usuários via navegador.

Figura 28 — Painel Web (Dashboard)
Apresenta a lista de chamados e seus status.

Figura 29 — Formulário Web
Tela de abertura de chamados via navegador.

Figura 30 — Acompanhamento Web
Consulta de andamento de chamados e mensagens de suporte.

Figura 31 — FAQ (Perguntas Frequentes)
Exibe respostas automáticas e ajuda via IA.

9. Suporte e Contato

Em caso de dúvidas ou problemas técnicos, entre em contato:
marcenariamadealves@gmail.com

Marcenaria Madealves — PIM IV (UNIP 2025/2)
Projeto: Sistema Integrado de Gestão de Chamados com IA
