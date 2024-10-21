using System;
/*
Implemente uma exceção personalizada chamada `TipoRegistroInvalidoException`. Ela deve ser lançada quando um `TipoRegistro` que não seja nem `Entrada` nem `Saida` for atribuído a um `Registro`.

**Tarefas**:
1. Crie a exceção personalizada `TipoRegistroInvalidoException`.
2. Implemente um método que recebe um `TipoRegistro` e lança a exceção se o tipo for inválido.
3. Utilize um bloco `try-catch` para capturar e exibir a mensagem de erro adequada. 
*/
namespace ProjetoBanco.Domain.Exceptions
{
    public class TipoRegistroInvalidoException : Exception
    {
        public TipoRegistroInvalidoException(string message) : base(message) { }
    }
}
