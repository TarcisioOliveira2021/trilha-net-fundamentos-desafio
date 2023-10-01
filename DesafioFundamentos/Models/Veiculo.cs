using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper();
        }

        public bool ValidarPlacaVeiculo(Veiculo veiculo)
        {
            if (!veiculo.Placa.Contains("-"))
            {
                return false;
            }

            if(veiculo.Placa.Length == 0 || veiculo.Placa.Length > 8)
            {
                return false;
            }

         return true;
        }
    }
}
