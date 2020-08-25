public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string returnString = string.Empty;

        foreach (char character in text)
        {
            returnString += Cipher(character, shiftKey);
        }

        return returnString;
    }

    public static char Cipher(char ch, int key)
    {
        // Do not care if it is not a letter, just return.
        if(!char.IsLetter(ch))
        {
            return ch;
        }

        // Is the value an Upper or Lower case?
        var d = char.IsUpper(ch) ? 'A' : 'a';

        // Works out the char to return
        return (char)((((ch + key) - d) % 26) + d);
    }
}