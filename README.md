# ContatosAPI
API desenvolvida com ASP.NET como treinamento para a empresa DTI.

## Uma breve explicação

Esta API tem como funcionalidade principal manusear e gerenciar uma lista de contatos para cada usuário criado, para isto conta com 
dois modelos, um modelo de usuário e outro de contato, onde um usuário tem uma lista de contatos e os contatos contém as informações 
pertinentes para sua identificação e utilização. A API também é dividida em duas rotas, uma para as ações relacionadas a usuários e outra
para as ações relacionadas aos contatos.

## Quais as funcionalidades?

São possíveis para mandar as API's os seguintes pedidos

**Rota de Usuário**
- Adicionar um usuário - Adiciona um usuário ao contexto da API e retorna o usuário adicionado.
- Remover um usuário - Remove um usuário do contexto da API e retorna o ID do usuário deletado.
- Visualizar um usuário - Retorna uma visualização de todas as informações pertinentes do usuário. 
- Visualizar todos os contatos - Retorna uma visualização de todos os contatos de um usuário.

**Rota de Contato**
- Adicionar contato - Adiciona um contato a um usuário e retorna o contato criado.
- Remover contato - Remove um contato de um usuário e retorna o ID do contato criado.
- Editar contato - Edita um contato de um usuário e retorna o contato editado.
- Visualizar Contato - Retorna uma visualização de um contato de um usuário .

![Imgur](https://i.imgur.com/h7NCblN.png)
