using System;
using System.Collections.Generic;
using System.Text;

namespace Aluracar.Model
{
    public class Carro
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return String.Format("R$ {0}", Valor);
            }
        }
    }
}
