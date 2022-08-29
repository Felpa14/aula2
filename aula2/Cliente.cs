using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    internal class Cliente
    {
        string nome;
        string cpf;
        string endereco;
        int idade;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCPF()
        {
            return this.cpf;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;

        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return this.idade;
        }
    }
}
