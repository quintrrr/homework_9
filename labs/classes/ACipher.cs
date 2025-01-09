using labs.interfaces;

namespace labs.classes;

public class ACipher : ICipher
{
    public string encode(string input)
    {
        string output = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (c != 'я' && c != 'Я')
                {
                    output += (char)(c + 1);
                }
                else output += c == 'я' ? 'а' : 'А';
            }
            else
            {
                output += c;
            }
        }
        return output;
    }

    public string decode(string input)
    {
        string output = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (c != 'а' && c != 'А')
                {
                    output += (char)(c - 1);
                }
                else output += c == 'а' ? 'я' : 'Я';
            }
            else
            {
                output += c;
            }
        }
        return output;
    }
}