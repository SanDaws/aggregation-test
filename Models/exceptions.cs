using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aggregation_test.Models;

public static class exceptions
{
    /*
    Esta clase se la dedico a la humanidad:
    si no fuera por ustedes no habria tenido que crearla
    */
    public static int safeInt(string arg)
    {
        int option = 0;
        Console.Write(arg);
        try
        {
            option = Convert.ToInt32(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Console.WriteLine("Respuesta No valida");
            safeInt("imposibe convertir, intente con un numero");

        }
        return option;

    }
    public static double safeDouble(string arg)
    {
        double option= 0;
        Console.Write(arg+": ");
        try
        {
            option = Convert.ToDouble(AntiEMptyorNull());
        }
        catch (FormatException)
        {
            Uti.TextoRojo("Respuesta No valida");
            safeDouble("imposibe convertir, intente con un numero");

        }
        return option;

    }

    public static string AntiEMptyorNull(){
            string texto;
        do
        {
            texto=Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(texto))
            {
                Uti.TextoRojo("Se prohibe texto vacio, ingrese datos validos: ");
            }
        } while (string.IsNullOrWhiteSpace(texto));

        return texto;
    }
}
