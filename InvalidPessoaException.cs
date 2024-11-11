using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoAprendizados
{
    #region SEMPRE_CRIAR_UMA_EXCEPTION_PADRAO
    public class InvalidPessoaException : Exception
    {
        private const string DEFAULT_MENSAGEM_PESSOA = "Cadastro de pessoa inválido";
        public InvalidPessoaException(string message = DEFAULT_MENSAGEM_PESSOA) : base(message) { 
 
        }
    }
    #endregion
}
