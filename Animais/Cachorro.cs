namespace ExAnimais.Animais
{
    public class Cachorro: Animal
    {
        public Cachorro(string tipo, int idade, int peso): base(tipo, idade,peso)
        {
            Tipo = tipo;
            Idade = idade;
            Peso = peso;
        }
    }
}
