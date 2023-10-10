using AppJogoDaForca.Models;

namespace AppJogoDaForca.Repositories;

public class WordRepository
{
    private readonly List<Word> _words;

    public WordRepository()
    {
        _words = new List<Word>
        {
            new Word("Animal", "Cachorro".ToUpper()),
            new Word("Animal", "Gato".ToUpper()),
            new Word("Animal", "Galinha".ToUpper()),
            new Word("Animal", "Pato".ToUpper()),
            new Word("Vegetal", "Cenoura".ToUpper()),
            new Word("Vegetal", "Alface".ToUpper()),
            new Word("Vegetal", "Beterraba".ToUpper()),
            new Word("Fruta", "Abacate".ToUpper()),
            new Word("Fruta", "Banana".ToUpper()),
            new Word("Fruta", "Caju".ToUpper()),
            new Word("Nome", "Maria".ToUpper()),
            new Word("Nome", "Joao".ToUpper()),
            new Word("Nome", "Jose".ToUpper()),
            new Word("Tempero", "Nordestino".ToUpper()),
            new Word("Tempero", "Baiano".ToUpper()),
            new Word("Tempero", "Mineiro".ToUpper())
        };
    }

    public Word GetRandomWord() 
        => _words[Random.Shared.Next(0, _words.Count)];
}
