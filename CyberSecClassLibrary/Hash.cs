using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

namespace CyberSecClassLibrary;

public class Hash
{
    public string SHA512(string incoming)
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

    public string MD5(string incoming)
    {
        byte[] hashBytes = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(incoming));
        
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }
        string hashResult = sb.ToString();

        return hashResult;
    }
    
    public string SHA1(string incoming)
    {
        byte[] hashBytes = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(incoming));
        
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }
        string hashResult = sb.ToString();

        return hashResult;
    }
    
    public string SHA256(string incoming)
    {
        byte[] hashBytes = new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(incoming));
        
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }
        string hashResult = sb.ToString();

        return hashResult;
    }
    
    public string _BCrypt(string incoming)
    {
        return BCrypt.Net.BCrypt.HashPassword(incoming);
    }
    
}