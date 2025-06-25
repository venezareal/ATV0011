using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0011.Models
{
    public class Atores
    {
        
        public string nome_ator;
        public string genero_ator;
        public string nacionalidade;
        public string idade;
        public string filmografia;

        public Atores()
        {
            

        }

        public override string ToString()
        {
            return $"{this.nome_ator}\n{this.genero_ator}\n{this.nacionalidade}\n{this.idade}\n{this.filmografia}";
        }

    }
}
