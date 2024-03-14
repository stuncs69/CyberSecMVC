using System.Security.Cryptography;
using System.Text;

namespace CyberSecClassLibrary;

public class SHA512
{
    public string Hash(string incoming)
    {
        byte[] hashBytes = new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes(incoming));
        
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }
        string hashResult = sb.ToString();

        return hashResult;
    }
}