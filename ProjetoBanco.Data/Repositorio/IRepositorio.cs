using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Data.Repositorio
{
    public interface IRepositorio<T>
    {
        void Adicionar(T item);
        T ObterPorId(int id);
        //IEnumerable<T> ObterTodos();
        void Atualizar(T item);
        void Deletar(int id);
    }
}
