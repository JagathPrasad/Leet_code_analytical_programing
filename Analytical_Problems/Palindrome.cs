



//Check Given String is Palindrome or Not


Palindrome("mam");

void Palindrome(string x)
{
    string a = string.Empty;
    string b = string.Empty;
    for (int i = 0; i < x.Length; i++)
    {
        Console.WriteLine(x[i]);
        a = a + x[i];
    }

    for (int i = (x.Length - 1); i >= 0; i--)
    {
        Console.WriteLine(x[i]);
        b = b + x[i];
    }

    if (a == b)
    {
        Console.WriteLine("Is Palindrome");
    }
    else
    {
        Console.WriteLine("Is not Palindrome");
    }
    
}