# 📚 InfoPill

Uma plataforma rápida e simplificada para consulta de informações de medicamentos, utilizando dados públicos da ANVISA.

---

## 📌 Visão Geral

O **InfoPill** é um projeto focado em fornecer informações básicas e acessíveis sobre medicamentos registrados na ANVISA.  
A proposta inicial é criar um MVP com backend em **.NET** e frontend em **Next.js**, priorizando a simplicidade, escalabilidade e qualidade de código.

---

## 🛠️ Tecnologias Utilizadas

- **Backend:**
    
    - .NET 8
        
    - ASP.NET Core Web API
        
    - Swagger
        
- **Frontend:**
    
    - Next.js
        
- **Outros:**
    
    - JSON para persistência inicial
        
    - Download e processamento de XMLs da ANVISA
        
    - Domain Driven Design (DDD) como guia de organização
        

---

## 📂 Estrutura do Projeto

bash

CopiarEditar

`InfoPill/ ├── src/ │   ├── InfoPill.API │   ├── InfoPill.Application │   ├── InfoPill.Communication │   ├── InfoPill.Domain │   ├── InfoPill.Infrastructure │   ├── InfoPill.Exception ├── tests/ │   └── (futuros testes de unidade e integração) ├── README.md └── InfoPill.sln`

---

## 🎯 Objetivos do MVP

-  Baixar e processar arquivos XML de medicamentos da ANVISA.
    
-  Persistir os dados processados em formato JSON.
    
-  Criar uma API para consultas básicas de medicamentos.
    
-  Criar um Frontend simples para busca e visualização de medicamentos.
    

---

## 🚀 Como Rodar o Projeto (MVP)

### Backend

1. Clone o repositório:
    
    bash
    
    CopiarEditar
    
    `git clone https://github.com/seu-usuario/infopill.git`
    
2. Navegue até a pasta `src/InfoPill.API` e execute:
    
    bash
    
    CopiarEditar
    
    `dotnet run`
    
3. Acesse a API pelo navegador:
    
    bash
    
    CopiarEditar
    
    `https://localhost:5001/swagger`
    

---

### Frontend

(Será incluído na fase de MVP do Frontend)

---

## 🛤️ Roadmap Futuro

- Integração com banco de dados real (PostgreSQL).
    
- Sistema de autenticação para acesso restrito.
    
- Melhorias de performance no processamento dos XMLs.
    
- Página de detalhes de medicamentos mais completa.
    
- Hospedagem do projeto em ambiente de produção.
    

---

## 🤝 Contribuindo

Ainda em fase de desenvolvimento interno.  
Contribuições futuras serão muito bem-vindas! 🚀

---

## 📄 Licença

Este projeto está licenciado sob a licença **MIT**.

---

> Criado com 💻 e ☕ por Evilis.
