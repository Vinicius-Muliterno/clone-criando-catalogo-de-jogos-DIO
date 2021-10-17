using criando_catalogo_de_jogos_DIO.InputModel;
using criando_catalogo_de_jogos_DIO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criando_catalogo_de_jogos_DIO.services
{
    public interface IJogoService : IDisposable 
    {

        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
