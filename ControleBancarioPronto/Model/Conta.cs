using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class Conta
    {
        private long _numero;
        protected decimal _saldo;
        public Cliente titular;

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;
            set
            {
                _saldo = value;
            }
        }

        public Conta(long numero)
        {
            _numero = numero;
        }

        public Conta(long numero, decimal saldo, Cliente titular)
        {
            if (saldo <= 10.00m)
            {
                throw new ArgumentException("O saldo inicial precisa ser acima de 10 reais.");
            }
            _numero = numero;
            _saldo = saldo;
            this.titular = titular ?? throw new ArgumentException("A conta deve ter um nome conectado a ela.");
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public decimal Saque(decimal valor)
        {
            decimal valorTotal = valor + 0.10m;

            if (_saldo - valorTotal >= 0)
            {
                _saldo -= valorTotal;
                return _saldo;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
        }

        public void Transferir(decimal valor, Conta contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Entre com algum valor.");
            }
            else if (valor > Saldo)
            {

                throw new InvalidOperationException("Não foi possível realizara a transferência");

            }
            this.Saldo -= valor;
            contaDestino.Saldo += valor;
        }

    }
}
