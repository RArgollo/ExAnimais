namespace ExAnimais.Animais
{
    public class Hamster: Animal
    {
        public Hamster(string tipo, int idade, int peso): base(tipo, idade,peso)
        {
            Tipo = tipo;
            Idade = idade;
            Peso = peso;
        }
    }
}