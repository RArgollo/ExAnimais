using ExAnimais.Animais;
namespace ExAnimais
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos animais deseja cadastrar?");
            int quantidadeAnimais = int.Parse(Console.ReadLine());
            Animal[] animais = new Animal[quantidadeAnimais];
            Pedido pedido = new Pedido("Rafael", 976973261, animais, quantidadeAnimais);
            pedido.PrecoConsulta();
        }
    }
}



