using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class Cliente
    {
        private string _email;
        private string _nome;
        private string _cpf;
        private DateTime _anoNascimento;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                if (value.Length == 11)
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("CPF inválido");
                }
            }
        }

        public DateTime AnoNascimento
        {
            get => _anoNascimento;
            set
            {
                if ((DateTime.Now.Year - value.Year) >= 18)
                {
                    _anoNascimento = value;
                }
                else
                {
                    throw new ArgumentException("Você precisa ser maior de idade.");
                }
            }
        }

        public int idade
        {
            get { return DateTime.Now.Year - AnoNascimento.Year; }
        }

        public Cliente()
        {
        }
        public Cliente(string nome, string cpf, DateTime anoNascimento, string email)
        {
            _email = email;
            _nome = nome;
            _cpf = cpf;
            _anoNascimento = anoNascimento;
        }


    }
}