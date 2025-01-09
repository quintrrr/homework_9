namespace labs.interfaces;

public interface ICipher
{
    string encode(string input);
    string decode(string input);
}