// See https://aka.ms/new-console-template for more information

//1. Converter
// Lag et program som kan konvertere valuta, temperatur eller vekt
// Du skal kunne få alternativer for hva du vil konvertere,
// velge hva du vil konvertere til, og så skrive inn en verdi før
// du får svar i konsollen.



class Converter
{

    public string fra;
    public string til;
    public double resultat;
    
    
    public static void Convert(string fra, string til, double resultat)
    {
        
        
    }

    public static void Valuta()
    {
        Console.WriteLine("Hvilken valuta vil du konvertere fra? dollar, euro, pund");
        string inputValutaFra = Console.ReadLine();
        Console.WriteLine("Hvilken valuta vil du konvertere til? dollar, euro, pund");
        string inputValutaTil = Console.ReadLine();
        double inputVerdi = 0;


        if (inputValutaFra == "euro")
        {
            if (inputValutaTil == "dollar")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
                
            }
            else if (inputValutaTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
        }
        else if (inputValutaFra == "dollar")
        {
            if (inputValutaTil == "euro")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
            else if (inputValutaTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
        }
        else if (inputValutaFra == "pund")
        {
            if (inputValutaTil == "euro")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
            else if (inputValutaTil == "dollar")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
        }
    }

    public static void Temperatur()
    {
        Console.WriteLine("Hvilken temperatur vil du konvertere fra? farenheight, celvin eller celsius");
        string inputTemperaturFra = Console.ReadLine();
        Console.WriteLine("Hvilken temperatur vil du konvertere til? farenheight, celvin eller celsius");
        string inputTemperaturTil = Console.ReadLine();
        
        if (inputTemperaturFra == "farenheight")
        {
            if (inputTemperaturTil == "celvin")
            {
               
            }
            else if (inputTemperaturTil == "celsius")
            {
                
            }
        }
        else if (inputTemperaturFra == "celvin")
        {
            if (inputTemperaturTil == "farenheight")
            {
                
            }
            else if (inputTemperaturTil == "celsius")
            {
                
            }
        }
        else if (inputTemperaturFra == "celsius")
        {
            if (inputTemperaturTil == "farenheight")
            {
                
            }
            else if (inputTemperaturTil == "celvin")
            {
                
            }
        }
    }

    public static void Vekt()
    {
        Console.WriteLine("Hvilken vekt vil du konvertere fra? kilogram, pund,");
        string inputVektFra = Console.ReadLine();
        Console.WriteLine("Hvilken vekt vil du konvertere til? kilogram, pund,");
        string inputVektTil = Console.ReadLine();
        double inputVerdi = 0;
        
        if (inputVektFra == "kilogram")
        {
            if (inputVektTil == "pund")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
        }
        else if (inputVektFra == "pund")
        {
            if (inputVektTil == "kilogram")
            {
                Console.WriteLine("Skriv verdien du vil konvertere");
                inputVerdi = Console.ReadLine();
            }
        }
        
    }

    public static void Start()
    {
        Console.WriteLine("Hva vil du konvertere? valuta, temperatur eller vekt?");
        string input = Console.ReadLine();
        

        if (input == "valuta")
        {
            Valuta();
        }
        else if (input == "temperatur")
        {
            Temperatur();
        }
        else if (input == "vekt")
        {
            Vekt();
        }
        else
        {
            Console.WriteLine("Ditt svar er ikke gyldig");
            Start();
        }
        
        
    }
    
}


