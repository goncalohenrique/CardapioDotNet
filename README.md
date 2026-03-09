# 🍽️ Goncalo Cardapio Api 01.00

Uma API de Cardápio Digital desenvolvida para explorar o ecossistema **.NET 9**. Este projeto marca minha transição do Java/Spring Boot para o C#/.NET, focando nas modernidades e facilidades que a plataforma Microsoft oferece.

## 🚀 O que aprendi: .NET vs. Spring Boot

Depois de mais de3 anos de experiência  com Java, este projeto é um laboratório em que analiso onde o .NET brilha em comparação ao Spring Boot.

### 1. Minimal APIs & Program.cs
Diferente do Spring, onde cada Controller exige anotações pesadas e classes separadas, usei **Minimal APIs**. Todo o pipeline da aplicação e as rotas são definidos de forma concisa no `Program.cs`.
* **No Java:** Muitas anotações (`@RestController`, `@RequestMapping`).
* **No .NET:** Código limpo, direto e de altíssima performance.

### 2. Injeção de Dependência (DI) Nativa
No ecossistema Java, o Spring Context gerencia os beans (geralmente via `@Autowired`). No .NET, a **Injeção de Dependência é nativa** do framework. Configurei o `CardapioDbContext` diretamente no `builder.Services`, sem necessidade de bibliotecas externas para o gerenciamento de ciclo de vida de objetos.

### 3. Gerenciamento com NuGet
Substituí o Maven (`pom.xml`) e o Gradle pelo **NuGet**.
* **Destaque:** O uso do pacote `Microsoft.EntityFrameworkCore.InMemory` para prototipagem rápida, mostrando a modularidade do .NET (você só instala o que realmente usa, mantendo o projeto mais leve).

### 4. Entity Framework Core (EF Core)
O equivalente ao Hibernate/JPA. Explorei o conceito de **Change Tracking**, onde o EF monitora alterações em objetos buscados no banco, permitindo updates (PUT) sem comandos explícitos de `save`, apenas chamando o `SaveChangesAsync()`.

---

## 🛠️ Tecnologias Utilizadas

* **C# 13 & .NET 9**
* **Entity Framework Core**: ORM para persistência de dados.
* **In-Memory Database**: Para testes rápidos sem necessidade de configurar um banco de dados externo (SQL Server/Postgres).
* **Swagger (OpenAPI)**: Documentação interativa gerada automaticamente para testar os endpoints.
* **HTTP Client (.http)**: Uso de arquivos `.http` integrados ao Rider para disparar requisições sem depender de ferramentas externas como Postman ou Insomnia.

---

## 📑 Como Testar

O projeto conta com ferramentas integradas para que você não precise de um Front-end para validar a lógica:

### Swagger
Com a aplicação rodando, acesse:
`http://localhost:5000/swagger` (ou a porta configurada no seu ambiente).

### Arquivo .http (Recomendado)
No diretório raiz, utilize o arquivo `Goncalo.Cardapio.Api.http`. Ele permite disparar requisições `GET`, `POST`, `PUT` e `DELETE` diretamente da IDE Rider ou VS Code.

---

## 📂 Estrutura do Projeto (versao 01.00)

* `Program.cs`: O "cérebro" da aplicação. Configuração de serviços, DI e definição das rotas.
* `Cardapio.cs`: Modelo de dados (Entity).
* `CardapioDbContext.cs`: Camada de acesso a dados e ponte entre o C# e o Banco de Dados.
* `Goncalo.Cardapio.Api.csproj`: Arquivo de configuração que gerencia as versões e pacotes NuGet.

---
**Próximos Passos:** Evoluir para uma arquitetura e adicionar persistência real dos dados com PostgreSQL.
