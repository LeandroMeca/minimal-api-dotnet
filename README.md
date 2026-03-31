# 🚀 Serviço de Cadastro com Minimal API (.NET)

API desenvolvida em **C# com .NET Minimal API** com foco em performance, simplicidade e boas práticas de desenvolvimento.  
O projeto implementa um serviço de cadastro com autenticação via JWT e integração com banco de dados MySQL.

---

## 📌 Sobre o Projeto

Este projeto foi criado com o objetivo de demonstrar:

* Criação de APIs modernas com **Minimal API**
* Implementação de autenticação segura com **JWT**
* Uso de **DTOs (Data Transfer Objects)** para organização e segurança dos dados
* Integração com banco de dados **MySQL**
* Documentação automática com **Swagger (OpenAPI)**

---

## 🛠️ Tecnologias Utilizadas

* **.NET** (C#)
* **MySQL** (Banco de dados relacional)
* **JWT** (JSON Web Token)
* **Swagger** (Documentação OpenAPI)
* **Git & GitHub**

---

## ⚙️ Funcionalidades

* ✅ **Cadastro de dados:** Persistência de informações no banco.
* 🔐 **Autenticação com JWT:** Segurança para as rotas da aplicação.
* 📄 **Swagger UI:** Documentação interativa para teste de endpoints.
* 🔄 **DTOs:** Abstração da camada de dados para comunicação segura.
* 🔒 **Middlewares de Segurança:** Controle de acesso a endpoints protegidos.

---

## 📂 Estrutura do Projeto

```bash
minimal-api-dotnet/
│
├── Endpoints/       # Definição das rotas e lógica de entrada
├── Models/          # Entidades do banco de dados
├── DTOs/            # Objetos de transferência de dados
├── Services/        # Regras de negócio e autenticação
├── Program.cs       # Configuração e inicialização da API
└── appsettings.json # Configurações de ambiente e conexão
