using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero) : base(numero)
        {
        }

        public ContaCaixinha(long numero, decimal saldo, Cliente titular) : base(numero, saldo, titular)
        {
        }

        public new void Deposito(decimal valor)
        {
            if (valor < 1.00m)
            {
                throw new ArgumentException("Depósitos inferiores a R$1,00 não são possíveis");
            }
            _saldo += 1.00m;
        }
        public new decimal Saque(decimal valor)
        {
            decimal valorTotal = valor + 0.10m;

            if (_saldo - valorTotal - 5.00m < 0)
            {
                throw new ArgumentException("Valor do saque maior que o saldo.");
            }
            _saldo -= 5.00m;
            return _saldo;
        }
    }
}