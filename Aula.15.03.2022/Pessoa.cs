using System;
using System.Collections.Generic;
using System.Text;

namespace Aula.Entidade
{
    class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome ??
                throw new ArgumentNullException(nameof(nome));
        }
    }
}