namespace CyberSecClassLibrary;

public class Caesar
{
    private char Cipher(char ch, int key) {  
        if (!char.IsLetter(ch)) {  
  
            return ch;  
        }  
  
        char d = char.IsUpper(ch) ? 'A' : 'a';  
        return (char)((((ch + key) - d) % 26) + d);  
    }  
  
  
    public string Encipher(string input, int key) {  
        string output = string.Empty;  
  
        foreach(char ch in input)  
            output += Cipher(ch, key);  
  
        return output;  
    }
}