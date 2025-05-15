# TaskHub 🧩

**TaskHub** é uma aplicação de gerenciamento de tarefas full-stack desenvolvida com .NET 9, ASP.NET Core, Entity Framework Core, Blazor e testes automatizados com xUnit. O objetivo deste projeto é consolidar conhecimentos essenciais para um desenvolvedor júnior e servir como portfólio.

---

## 📌 Funcionalidades

- [ ] Cadastro de usuários e login com Identity
- [ ] Criação, edição e exclusão de tarefas
- [ ] Agrupamento por categorias e status
- [ ] Interface moderna com Blazor (Server ou WASM)
- [ ] Dashboard com métricas e gráficos
- [ ] Exportação para Excel e PDF
- [ ] Testes unitários e de integração
- [ ] Camadas bem definidas (Domain, Application, Infrastructure, Web, Api)

---

## 🧱 Estrutura de Pastas

TaskHub/ 

├── TaskHub.Api/				# ASP.NET Core Web API

├── TaskHub.Web/ 				# Blazor Front-End

├── TaskHub.Application/ 		# Casos de uso, serviços e interfaces

├── TaskHub.Domain/ 			# Entidades e interfaces do domínio

├── TaskHub.Infrastructure/ 	# Implementações de persistência e serviços externos

├── TaskHub.UnitTests/ 			# Testes unitários (xUnit)

├── TaskHub.IntegrationTests/ 	# Testes de integração (xUnit)

└── README.md

---

## 🚀 Tecnologias e Bibliotecas

- [.NET 9](https://dotnet.microsoft.com/)
- [ASP.NET Core Web API](https://learn.microsoft.com/aspnet/core)
- [Blazor (Server/WASM)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Entity Framework Core (EF)](https://learn.microsoft.com/ef/)
- [xUnit](https://xunit.net/)
- [FluentAssertions](https://fluentassertions.com/)
- [Moq](https://github.com/moq/moq4)
- [Radzen Blazor Components](https://blazor.radzen.com/)
- [MudBlazor](https://mudblazor.com/)

---

## 📦 Como executar localmente

1. Clone o repositório:
	```bash
	git clone https://github.com/seu-usuario/taskhub.git
	cd taskhub
	```
   
2. Restaure os pacotes e compile:
	```bash
	dotnet restore
	dotnet build
	```
   
3. Execute o projeto:
	```bash
	dotnet run --project TaskHub.Api
	```
   
4. Acesse o front-end (caso esteja usando Blazor Web):
	```bash
	dotnet run --project TaskHub.Web
	```
5. Acesse em: http://localhost:5000

---

## 🧪 Executar os testes
   ```bash
   dotnet test TaskHub.UnitTests
   dotnet test TaskHub.IntegrationTests
   ```

---

## 🧠 Aprendizados e Boas Práticas

	Programação orientada a domínio (DDD light)
	Separação de responsabilidades por camadas
	Testes automatizados desde o início
	Autenticação com ASP.NET Identity
	Uso de Injeção de Dependência
	Configuração de banco em memória para testes

---

## 📄 Licença
[![License - MIT](https://img.shields.io/github/license/radzenhq/radzen-blazor?logo=github&style=for-the-badge)](https://github.com/udutra/TaskHub/LICENSE)