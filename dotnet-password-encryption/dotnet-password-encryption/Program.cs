// See https://aka.ms/new-console-template for more information
using dotnet_password_encryption;

var password = "";

while (true)
{
    Console.Write("Type Password: ");
    password = Console.ReadLine(); 
    if (!string.IsNullOrEmpty(password))
    {
        if (password.Equals("exit"))
            break;
        
        // md
        Console.WriteLine("MD5: " + MdFamily.ComputeMd5(password));

        //sha
        Console.WriteLine("SHA1: " + ShaFamily.ComputeSha1(password));
        Console.WriteLine("SHA256: " + ShaFamily.ComputeSha256(password));
        Console.WriteLine("SHA512: " + ShaFamily.ComputeSha512(password));
    }
}
