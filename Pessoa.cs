using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestandoAprendizados
{
    public class Pessoa
    {

        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; } = 0;

        public Pessoa()
        {
        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome.Trim();
            Idade = idade;
        }

        #region IMPLICIT_OPERATOR
            //Converte Pessoa para String
            public static implicit operator string(Pessoa pessoa) => pessoa.Nome;
            //Converte String para Pessoa
            public static implicit operator Pessoa(string pessoa) 
                => new Pessoa() 
                { 
                    Nome = pessoa
                };

        /*
         * 
         * Pessoa n1 = new Pessoa()
            {
                Nome = "Otavio",
                Idade = 19
            };

            string n2 =  n1;

            string p1 = "teste";
            Pessoa p2 = p1;

            Console.WriteLine(p2);
        */
        #endregion


        #region BOA_PRÁTICA
        //Sempre colocar o ToString()
        public override string ToString() => $"Nome: {Nome} {Environment.NewLine}Idade: {Idade}";

        #endregion

    }
}
