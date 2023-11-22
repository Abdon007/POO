using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.teste
{
    public class Consumidor

    {
        public int Id { get; private set; }
        public string nome { get; private set; }


        public Consumidor(string Nome)
        {
            nome = Nome;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }
}
