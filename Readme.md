# Gestão de Alunos

Este repositório contém uma aplicação simples para gerenciar informações de alunos, incluindo funcionalidades para leitura, gravação e atualização dos dados dos alunos em um arquivo de texto.

## Estrutura do Projeto

1. **Classes**
    - `Aluno`: Representa um aluno com as seguintes propriedades:
        - `RA` (int): Registro Acadêmico.
        - `Nome` (string): Nome do aluno.
        - `Turma` (string): Turma do aluno.
        - `Cpf` (string): CPF do aluno.
    - `Manipula`: Contém métodos para manipulação dos dados dos alunos armazenados em um arquivo de texto:
        - `Gravar(string texto)`: Grava uma string no arquivo.
        - `ler()`: Lê os dados dos alunos do arquivo e retorna uma lista de objetos `Aluno`.
        - `Alterar(Aluno a)`: Altera os dados de um aluno específico no arquivo.
2. **Program**
    - `Main`: Ponto de entrada da aplicação. Demonstra o uso das funcionalidades da classe `Manipula` para ler e alterar os dados dos alunos.

## Funcionalidades

- **Gravação de Dados**: Grava informações de alunos no arquivo `Dados.txt`.
- **Leitura de Dados**: Lê as informações dos alunos do arquivo e retorna uma lista de objetos `Aluno`.
- **Alteração de Dados**: Permite alterar os dados de um aluno específico no arquivo.

## Como Usar

1. Clone este repositório:
    ```sh
    git clone <URL_DO_REPOSITORIO>
    ```
2. Navegue até o diretório do projeto e abra o arquivo `Program.cs`.
3. Utilize os métodos da classe `Manipula` para gerenciar os dados dos alunos conforme necessário.

## Exemplo de Uso

```csharp
Manipula arquivo = new Manipula();
Aluno novoAluno = new Aluno(123456, "João Silva", "1A", "123.456.789-00");
arquivo.Gravar(novoAluno.RA + ";" + novoAluno.Nome + ";" + novoAluno.Turma + ";" + novoAluno.Cpf);
List<Aluno> alunos = arquivo.ler();
foreach(Aluno aluno in alunos)
{
    Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.Nome}, Turma: {aluno.Turma}, CPF: {aluno.Cpf}");
}
novoAluno.Nome = "João da Silva";
arquivo.Alterar(novoAluno);