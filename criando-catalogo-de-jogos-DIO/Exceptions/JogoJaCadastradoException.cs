using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace criando_catalogo_de_jogos_DIO.Exception
{
    public class JogoJaCadastradoException : RankException
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}
