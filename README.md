# Gerenciador-de-tarefas
O Gerenciador de Tarefas é uma aplicação desenvolvida em .NET Web API utilizando o Entity Framework Core para persistência de dados. O sistema tem como objetivo fornecer uma forma simples e organizada de gerenciar a rotina do usuário por meio do cadastro de tarefas.  
A aplicação implementa um CRUD completo (Create, Read, Update e Delete), permitindo:

Criar novas tarefas com título, descrição, data e status.

Consultar todas as tarefas cadastradas ou uma tarefa específica.

Atualizar os dados de uma tarefa existente.

Excluir tarefas que não são mais necessárias.

🔑 Estrutura da Classe Principal (Tarefa)

Id: identificador único da tarefa.

Titulo: título da tarefa.

Descricao: detalhes da tarefa.

Data: data relacionada à tarefa (prazo ou agendamento).

Status: estado atual da tarefa (ex.: "Pendente", "Concluída").

⚙️ Tecnologias Utilizadas

.NET 8 (Web API)

Entity Framework Core

SQL Server

Swagger (para documentação e testes da API).
