using labs.interfaces;

namespace labs.classes;

public class BCipher : ICipher
{
    public string encode(string input)
    {
        string output = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                output += char.IsUpper(c) ? (char)('Я' - c + 'А') : (char)('я' - c + 'а');
            }
            else output += c;
        }
        return output;
    }

    public string decode(string input)
    {
        return encode((input));
    }
}