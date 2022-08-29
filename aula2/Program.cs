using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração e instanciação do objeto
            Produto prod = new Produto();
            Cliente cli = new Cliente();

            Console.WriteLine("Digite o nome do cliente: ");
            cli.setNome(Console.ReadLine());
            Console.WriteLine("Digite a CPF do cliente: ");
            cli.setCpf(Console.ReadLine());
            Console.WriteLine("Digite a endereço do cliente: ");
            cli.setEndereco(Console.ReadLine());
            Console.WriteLine("Digite a idade do cliente: ");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Digite a descrição do produto: ");
            prod.setDescricao(Console.ReadLine());
            Console.WriteLine("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Código = "+ prod.getCodigo() + "\nDescrição" + prod.getDescricao() + "\nCategoria" + prod.getCategoria() + "\nValor = " +prod.getValor().ToString("C"));
        }

    }
}
