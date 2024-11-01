

using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

Main();
void Main()
{
    while (true)
    {
        string texttoencrypt = Console.ReadLine();

        Console.WriteLine("Encrypted: " + Text_encryptor(texttoencrypt));
        Console.WriteLine("Decrypted: " + Text_decryptor(Text_encryptor(texttoencrypt)));
    }
};

string Text_encryptor(string text)
{
    char[] arr = {'d', 'О', 'щ', '?', '<', 'ь', '6', 'Ъ', 'У', 'А', '-', '$', 'Л', 'n',
        '8', 'k', 'о', ';', 'Q', 'p', 'х', 'К', 'y', 'r', 'ъ', '=', 'X', 'Ю', 'Й', 'Б',
        'Э', 'у', 'x', 'C', 'U', 'Y', 'V', 'т', 'Ф', 'l', 'Т', 'Г', 'o', 'R', 'm', 'З',
        'G', 'W', 'Н', 'g', 'Z', 'е', 'z', ']', 'F', 'A', 'Щ', '9', 'Я', 'н', 'ф', 'B',
        'Д', 'р', 'Е', '&', 'q', 'э', 'д', '*', '5', 'ш', '}', 'М', '~', 'б', '2', 'я',
        'E', '0', 'с', 'В', '_', ':', 'a', 'i', 'Р', 'Ч', 'Х', 'u', 'Ш', 'I', 'И', 'и',
        'г', '>', '^', '{', 'Ц', 'ю', 'Ы', 'й', 'п', 'w', 't', '/', 'f', '@', 'c', 'ы',
        'П', 'e', 'ё', 'S', 'b', '4', 'м', '1', 'L', ' ', 's', '[', 'а', 'в', '+', 'N',
        '7', 'M', '3', 'H', 'ц', 'Ь', 'з', 'л', '`', '|', 'v', 'J', 'P', 'K', 'ч', 'ж',
        'к', 'j', 'Ж', 'Ё', '%', '#', 'h', 'O', 'D', 'С', 'T' };

    string encrypted = "";
    char[] textarr = text.ToCharArray();

    for (int i = 0; i < textarr.Count(); i++)
    {

        for (int j = 0; j < arr.Length; j++)
        {

            int x = new Random().Next(j, arr.Count());
            if (arr[j] == textarr[i]) // PYTHON BLYAT
            {
                encrypted += Convert.ToString(arr[x - j]) + Convert.ToString(arr[x]);
                break;
            }
        }
    }
    return encrypted;
    
}

string Text_decryptor(string text)
{
    char[] arr = {'d', 'О', 'щ', '?', '<', 'ь', '6', 'Ъ', 'У', 'А', '-', '$', 'Л', 'n',
        '8', 'k', 'о', ';', 'Q', 'p', 'х', 'К', 'y', 'r', 'ъ', '=', 'X', 'Ю', 'Й', 'Б',
        'Э', 'у', 'x', 'C', 'U', 'Y', 'V', 'т', 'Ф', 'l', 'Т', 'Г', 'o', 'R', 'm', 'З',
        'G', 'W', 'Н', 'g', 'Z', 'е', 'z', ']', 'F', 'A', 'Щ', '9', 'Я', 'н', 'ф', 'B',
        'Д', 'р', 'Е', '&', 'q', 'э', 'д', '*', '5', 'ш', '}', 'М', '~', 'б', '2', 'я',
        'E', '0', 'с', 'В', '_', ':', 'a', 'i', 'Р', 'Ч', 'Х', 'u', 'Ш', 'I', 'И', 'и',
        'г', '>', '^', '{', 'Ц', 'ю', 'Ы', 'й', 'п', 'w', 't', '/', 'f', '@', 'c', 'ы',
        'П', 'e', 'ё', 'S', 'b', '4', 'м', '1', 'L', ' ', 's', '[', 'а', 'в', '+', 'N',
        '7', 'M', '3', 'H', 'ц', 'Ь', 'з', 'л', '`', '|', 'v', 'J', 'P', 'K', 'ч', 'ж',
        'к', 'j', 'Ж', 'Ё', '%', '#', 'h', 'O', 'D', 'С', 'T' };

    string decrypted ="";

    char[] textarr = text.ToCharArray();

    for (int i = 0; i < textarr.Count(); i+=2)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (textarr[i] == arr[j])
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (textarr[i+1] == arr[k])
                    {
                        decrypted += Convert.ToString(arr[k-j]);
                        break;
                    }
                }
                break;
            }
        }
        
    }
    return decrypted;
}
