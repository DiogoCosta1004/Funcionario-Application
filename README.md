# 🧑‍💼 Sistema de Gestão de Funcionários

## 📘 Descrição

O **Sistema de Gestão de Funcionários** é uma solução completa para o controle e a administração de colaboradores em uma organização. Ele oferece recursos como cadastro de funcionários, departamentos, filiais, controle de férias, horas extras e sanções, além de gerenciamento de autenticação de usuários.

Este projeto foi desenvolvido como parte do **Projeto Integrador I**, aplicando conhecimentos de Estrutura de Dados Avançada, Lógica para Computação e Banco de Dados. A tecnologia escolhida para construir a aplicação foi a stack ASP.NET Core, Blazor e SQL Server.

## 🚀 Funcionalidades

-   Cadastro, edição e exclusão de funcionários.
-   Gerenciamento de departamentos e filiais.
-   Registro e controle de férias, horas extras e sanções disciplinares.
-   Gerenciamento de localidades: países, cidades e bairros.
-   Módulo de autenticação com gerenciamento de usuários e permissões.
-   Upload e visualização de fotos de perfil dos funcionários.

## 🛠️ Tecnologias Utilizadas

-   **.NET 9** com ASP.NET Core
-   **Entity Framework Core**
-   **SQL Server**
-   **C# 13** (ou a versão correspondente)
-   **Bootstrap** para estilização

## 🗃️ Estrutura de Dados

Baseado no `AppDbContext` do Entity Framework Core, o sistema gerencia as seguintes entidades principais:

-   **Entidades de Negócio:** `Funcionario`, `Departamento`, `Filial`
-   **Entidades de Controle:** `Ferias` (Vacation), `HoraExtra` (Overtime), `Sancao` (Sanction)
-   **Entidades de Autenticação:** `ApplicationUser`, `SystemRole`, `UserRole`, `RefreshTokenInfo`

## ⚙️ Como Executar Localmente

### ✅ Pré-requisitos

-   [.NET SDK 9.0](https://dotnet.microsoft.com/pt-br/download) ou superior
-   SQL Server (local ou na nuvem)
-   Visual Studio 2022 ou Visual Studio Code

### 🧪 Etapas

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/sistema-gestao-funcionarios.git](https://github.com/seu-usuario/sistema-gestao-funcionarios.git)
    cd sistema-gestao-funcionarios
    ```

2.  **Configure a string de conexão:**
    Abra o arquivo `appsettings.json` e ajuste a `DefaultConnection` com os dados do seu banco de dados:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=SEU_SERVIDOR;Database=GestaoFuncionariosDB;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```

3.  **Aplique as migrations para criar o banco de dados:**
    Execute o comando abaixo no terminal, na pasta raiz do projeto:
    ```bash
    dotnet ef database update
    ```
4. **Execute a aplicação:**
     ```bash
    dotnet run
    ```

     ## 📞 Contato

Para dúvidas ou sugestões, entre em contato:

- Email: 

- LinkedIn:

- GitHub:

---

## 📝 Melhorias Futuras

- Implementar relatórios analíticos para RH.

- Integração com serviços externos (ex: folha de pagamento).

- Sistema de notificações por email.

- Mobile app para gestão remota.

  ## 👥 Trabalho em Grupo

Este projeto foi desenvolvido em grupo, reunindo esforços e conhecimentos complementares dos membros para alcançar um resultado robusto e funcional. A colaboração e a divisão de tarefas permitiram uma maior eficiência no desenvolvimento, além de promover a troca de aprendizados entre os participantes.

Cada integrante contribuiu em áreas específicas do sistema, como backend, frontend, banco de dados e testes, fortalecendo o trabalho em equipe e a integração entre as tecnologias utilizadas.

---

## 🏁 Conclusão

O **Sistema de Gestão de Funcionários** representa um importante passo na aplicação prática dos conhecimentos adquiridos durante o curso, consolidando habilidades em desenvolvimento web, arquitetura de software e banco de dados.

O projeto não só atende às necessidades básicas de controle de colaboradores e departamentos, como também serve como base para futuras melhorias e expansões, mostrando o potencial de soluções tecnológicas para otimizar processos organizacionais.

A experiência coletiva reforçou o valor do trabalho em equipe e a importância do planejamento estruturado para o sucesso de um sistema complexo.

---
