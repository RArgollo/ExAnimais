namespace ExAnimais.Animais
{
    public class Gato: Animal
    {
        public Gato(string tipo, int idade, int peso): base(tipo, idade,peso)
        {
            Tipo = tipo;
            Idade = idade;
            Peso = peso;
        }
    }
}

