using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Domain;

namespace ProjetoBanco.Data.Repositorio
{
    public class RepositorioExtrato : IRepositorio<Extrato>
    {
        private List<Extrato> Extratos = new List<Extrato>();

        public void Adicionar(Extrato item)
        {
            Extratos.Add(item);
        }

        public Extrato ObterPorId(int id)
        {
            var ext = Extratos.Select(e => e.ID == id);
            return (Extrato)ext;
        }

        /*
        public IEnumerable<Extrato> ObterTodos()  
        {
            foreach (var ext in Extratos)
            {
                
            }
            
        }
        */

        public void Deletar(int id)
        {
            //Selecionar o Extrato de Id (tal i) para posteriormente deletar 
            var del = Extratos.Select(i => i.ID == id); 
        }

        public void Atualizar(Extrato item)
        {
            
        }
    }
}
