using System;

class Program
{
    static void Main()
    {
        string e = GetTimeStamp();
        string d = GetTimeStamp2();
        string f = GetTimeStamp();
        Console.WriteLine("Hola mundo!");   // muestra un texto

        Console.WriteLine(e);
        Console.WriteLine(EncriptarId(e));
        Console.WriteLine(RandomString(8));
        Console.WriteLine(d);
        Console.WriteLine(f);
        Console.ReadLine();     // espera una entrada por texto del usuario
    }

    static string EncriptarId(string valor)
    {
        valor = valor.Replace("1", "x");
        valor = valor.Replace("2", "V");
        valor = valor.Replace("3", "h");
        valor = valor.Replace("4", "2");
        valor = valor.Replace("5", "C");
        valor = valor.Replace("6", "1");
        valor = valor.Replace("7", "k");
        valor = valor.Replace("8", "Y");
        valor = valor.Replace("9", "E");
        valor = valor.Replace("0", "q");

        return valor;
    }

    
    public static string RandomString(int length)
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[length];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        var finalString = new String(stringChars);
        return finalString;
    }

    static string GetTimeStamp()
    {
        string sFecha = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00");
        string sHora = DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00")
                        + DateTime.Now.Millisecond.ToString("000");
        return sFecha + sHora;
    }

    static string GetTimeStamp2()
    {
        string sFecha = DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00");
        string sHora = DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00");
        return sFecha + sHora;
    }
}

