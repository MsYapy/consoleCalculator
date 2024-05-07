// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using basicA;

class Calculator
{
    public static void Main(string[] args)
    {
       
        List<decimal> results = new List<decimal>();
        int Op = 0;
        do
        {
            if (results.Count != 0)
            {
               Console.WriteLine("v) Continuar operando sobre el resultado \nf) Iniciar nueva operacion");
                string conti = Console.ReadLine();
                if (conti == "v")
                {
                    Console.WriteLine($"Cantidad de resultados: {results.Count}");
                    foreach (int i in results) 
                    {
                     Console.Write($"{i}, ");              
                    }
                    Console.WriteLine($"\nSeguir operando sobre el resultado {results[results.Count -1]}");
                }
                else{
                  results.Clear();
                  Console.WriteLine($"Continuar operando");  
                }
            }
            Console.WriteLine(" Calculadora de consola \n"
             + "1) Sumar \n2) Resta\n3) Multiplicar\n4) Dividir\n5) Salir");
            string items = Console.ReadLine();
            Op = int.Parse(items);

            if (Op > 5 || Op < 1)
            {
                Console.WriteLine("*** Elija el numero segun las opciones del menu ***");
            } 
            else if (Op == 5) 
            {
                Console.WriteLine("BYE..");
                Environment.Exit(0);
            }
            else
            {

                if (results.Count > 0) 
                {
                    results.Add(MenuCalculator(Op, results[results.Count - 1]));
                } else
                {
                    results.Add(MenuCalculator(Op));
                }
              
            }
        }
        while (Op != 5);
    }


    public static decimal MenuCalculator(int item, decimal r = 0)
    {
        Operations operations = new Operations();
        if (r != 0) 
        {
            operations.result = r;  
        }
        switch (item)
        {
            case 1:
                Console.WriteLine("Suma");
                operations.sumar();
                break;
            case 2:
                Console.WriteLine("Resta");
                operations.Restar();
                break;
            case 3:
                Console.WriteLine("Multiplicacion");
                operations.Multiplicar();
                break;
            case 4:
                Console.WriteLine("Dividir");
                operations.Divividir(); 
                break;
            default:
                Console.WriteLine();
                break;
        }
        Console.WriteLine("Resultado = " +operations.result);
        return operations.result;
    }
}