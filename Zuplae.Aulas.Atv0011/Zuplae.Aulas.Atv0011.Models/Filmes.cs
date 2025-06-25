using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0011.Models
{
    public class Filmes
    {
        public string titulo;
        public string ano_filme;
        public string genero_filme;
        public string diretor;
        public string roteirista;
        public string classificacao_indicativa;
        


        public Filmes()
        {
            
        }


        public override string ToString()
        {
            return $"{this.titulo}\n{this.ano_filme}\n{this.genero_filme}\n{this.diretor}\n{this.roteirista}\n{this.classificacao_indicativa}{" anos"}";
        }
    }
}
