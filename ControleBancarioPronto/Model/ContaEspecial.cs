using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class ContaEspecial : Conta
    {

        private decimal _limite;

        public decimal Limite
        {
            get
            {
                return _limite;
            }
            set
            {
                _limite = value;
            }

        }
        public ContaEspecial(long numero) : base(numero)
        {
        }

        public ContaEspecial(long numero, decimal saldo, decimal limite, Cliente titular) : base(numero, saldo, titular)
        {
            _limite = limite;
        }



        public bool Sacar(decimal valor)
        {

            if (_saldo + Limite >= valor + 0.10m)
            {
                _saldo -= valor + 0.10m;
                return true;
            }
            else
            {
                throw new ArgumentException("Saldo Insuficiente");
            }

        }

        public void Transferir(decimal valor, Conta contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor da transferência deve ser maior que 0");
            }
            if (_saldo + Limite < valor)
            {
                throw new InvalidOperationException("Saldo e limite insuficientes para realizar transferência");
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
        }

    }
}