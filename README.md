## 🧪 Desafio Técnico - Desenvolvedor .NET Core
📝 Descrição

Crie uma pequena aplicação web com API em ASP.NET Core e, opcionalmente, uma interface simples em React ou Postman para testar os endpoints.

---

## 🎯 Objetivos
📌 Back-End (.NET Core)

Crie uma API para gerenciamento de contatos com as seguintes funcionalidades:

Endpoints obrigatórios

GET /api/contacts: listar todos os contatos  
GET /api/contacts/{id}: buscar contato por ID  
POST /api/contacts: adicionar novo contato  
PUT /api/contacts/{id}: editar contato  
DELETE /api/contacts/{id}: remover contato  

---

## Modelo de dados

```csharp
public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
```

---

## 🔐 Requisitos Técnicos do Back-End

- ASP.NET Core (preferencialmente versão 8 ou superior)
- Entity Framework Core (banco SQLite)
- Seguir padrão REST
- Código organizado (separar controller, model e context)
- Uso de DTOs (CreateContactDto e ContactDto)
- Permitir testes via Swagger

---

## 💻 (Opcional) Front-End (React)

- Página para listar contatos
- Formulário para criar/editar contatos
- Botões para excluir contatos
- Pode ser feito com Vite + Tailwind ou CRA + CSS básico

---

## ✅ Critérios de Avaliação

| Critério                       | Peso |
|-------------------------------|------|
| Funcionamento básico da API   | ⭐⭐⭐⭐ |
| Organização e clareza do código | ⭐⭐⭐ |
| Uso correto do Entity Framework | ⭐⭐ |
| Uso de boas práticas REST     | ⭐⭐ |
| (Opcional) Interface React    | ⭐ |

---

## 📦 Entrega esperada

- Repositório GitHub com:
  - Código fonte da API
  - README com instruções para rodar (via Swagger ou Postman)
  - (Opcional) Código front-end

---

## ⏱️ Tempo sugerido para conclusão

2 a 3 dias úteis

---

## ▶️ Como rodar o projeto

### 🔙 Backend (.NET Core)

1. Restaure os pacotes:
```bash
dotnet restore
```

2. Execute as migrações e crie o banco:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

3. Execute a aplicação:
```bash
dotnet run
```

Acesse:

http://localhost:5107/swagger  
ou  
https://localhost:7076/swagger  
```
