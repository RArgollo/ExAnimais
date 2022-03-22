namespace ExAnimais.Animais
{
    public class Animal
    {
        public string Tipo { get; set; }
        public int Idade { get; set; }
        public int Peso { get; set; }
        public Animal(string tipo, int idade, int peso)
        {
            Tipo = tipo;
            Idade = idade;
            Peso = peso;
        }
        public int Comer(string animal)
        {
            switch (animal)
            {
                case "cachorro":
                    return 100;

                case "gato":
                    return 50;

                case "hamster":
                    return 25;
                default:
                    return 0;

            }
        }
        public int TomarBanho(string animal)
        {
            switch (animal)
            {
                case "cachorro":
                    return 40;
                case "gato":
                    return 30;

                case "hamster":
                    return 15;
                default:
                    return 0;
            }
        }

    }
}
