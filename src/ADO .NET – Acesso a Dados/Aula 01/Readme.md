Vamos considerar um exemplo de um sistema simples de gerenciamento de biblioteca com duas entidades principais: Livro e Autor.

1. **Entidade Livro:**
   - Atributos: ISBN (chave primária), Título, Ano de Publicação, Gênero, etc.

2. **Entidade Autor:**
   - Atributos: ID Autor (chave primária), Nome do Autor, Data de Nascimento, Nacionalidade, etc.

3. **Relacionamento:**
   - Um livro pode ser escrito por um ou mais autores.
   - Um autor pode escrever um ou mais livros.

Agora, no diagrama:

- Desenhe dois retângulos, representando as entidades "Livro" e "Autor".
- Dentro de cada retângulo, liste os atributos correspondentes a cada entidade.
- Desenhe uma linha entre os retângulos "Livro" e "Autor" para representar o relacionamento. Coloque um rótulo nessa linha indicando a natureza do relacionamento, por exemplo, "Escreve".
- Se um livro pode ter vários autores ou vice-versa, use notação de "crow's foot" (um símbolo semelhante a uma pata de corvo) na extremidade da linha para indicar a multiplicidade. Por exemplo, um "crow's foot" no lado do "Autor" indicaria "muitos autores".

Se você estiver usando uma ferramenta específica para criar diagramas de entidade-relacionamento, como o MySQL Workbench, você pode arrastar e soltar entidades e relacionamentos para construir seu diagrama visualmente.

Lembre-se de que este é apenas um exemplo simples. Diagramas de entidade-relacionamento podem se tornar mais complexos com mais entidades e relacionamentos dependendo dos requisitos do sistema que você está modelando.