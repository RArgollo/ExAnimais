using ExAnimais.Animais;
namespace ExAnimais
{
    public class Pedido
    {
        public string NomeDoDono { get; set; }
        public int TelefoneDoDono { get; set; }
        public Animal[] Animais { get; set; }
        public int Preco { get; set; }
        public int QuantidadeAnimais { get; set; }
        public Pedido(string nomeDoDono, int telefoneDoDono, Animal[] animais,int quantidadeAnimais)
        {
            NomeDoDono = nomeDoDono;
            TelefoneDoDono = telefoneDoDono;
            Animais = animais;
            QuantidadeAnimais = quantidadeAnimais;
        }
        public void CadastrarAnimais()
        {
            Animais = new Animal[QuantidadeAnimais];
            for (int contador = 0; contador < QuantidadeAnimais; contador++)
            {
                Console.WriteLine("Digite o tipo de animal (cachorro, gato ou hamster): ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Digite a idade do animal: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso do animal: ");
                int peso = int.Parse(Console.ReadLine());
                switch(tipo){
                    case "cachorro":
                    Animais[contador] = new Cachorro(tipo, idade, peso);
                    break;
                    case "gato":
                    Animais[contador] = new Gato(tipo, idade, peso);
                    break;
                    case "hamster":
                    Animais[contador] = new Hamster(tipo, idade, peso);
                    break;
                }
                Animais[contador] = new Gato(tipo, idade, peso);
            }
        }
        public void PrecoConsulta()
        {
            CadastrarAnimais();
            for (int contador = 0; contador < QuantidadeAnimais; contador++)
            {
                int preço = (Animais[contador].Comer(Animais[contador].Tipo) * 2) + (Animais[contador].TomarBanho(Animais[contador].Tipo) * 3);
                Console.WriteLine($"O preço da consulta do {Animais[contador].Tipo} é: {preço}");
            }
        }
    }
}
