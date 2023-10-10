namespace AppJogoDaForca.Extensions;

public static class StringExtensions
{
    public static List<int> AllIndexesOf(this string str, string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("O valor não pode ser nulo ou vazio.", nameof(value));

        var list = new List<int>();
        for (int index = 0; ; index += value.Length)
        {
            index = str.IndexOf(value, index);

            if (index == -1)
                return list;

            list.Add(index);
        }
    }
}
