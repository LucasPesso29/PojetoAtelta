using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetoAtelta
{
    class Atleta
    {
        private string nome;
        private double peso;
        private double altura;
        private int idade;

        public string Nome
        {
            set 
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatóriamente.");
                }

            }
            get { return this.nome; }
        }
         
        public double Peso 
        {
            set
            {
                if (value >= 45)
                {
                    this.peso = value;
                }
                else 
                {
                    throw new Exception("O peso deverá se maior que 45 quilos.");
                }
            }
            get { return this.peso; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura deverá ser maior que 1 metro.");
                }

            }
            get { return this.altura; }
        }

        public int Idade
        {

            set
            {
                if ( value >= 18)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade de ver maior que 18 anos.");
                }
            }
            get { return this.idade; }
        }

        public double Calcular_IMC()
        {
            return (peso / (altura * altura));
        }
    }

}
