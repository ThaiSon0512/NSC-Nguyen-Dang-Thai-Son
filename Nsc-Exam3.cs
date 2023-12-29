using System;
using System.Security.Cryptography;
using System.Text;

public class PasswordEncryptionExample
{
    public static void Main()
    {
        string username = "Admin";
        string password = "Adwx!@#$%xdwa";

        string hashedPassword = EncryptPassword(password);

        Console.WriteLine("Username: " + username);
        Console.WriteLine("Hashed Password (SHA-256): " + hashedPassword);
    }

    
    public static string EncryptPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                builder.Append(hashedBytes[i].ToString("x2")); 
            }

            return builder.ToString();
        }
    }
}