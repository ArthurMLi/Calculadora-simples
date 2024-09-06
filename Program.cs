// See https://aka.ms/new-console-template for more information
double n1;
double n2;
string sinal;
double resultado = 0;
int cont = 0;
while (cont != 1)
{
    try
    {
        Console.WriteLine("Escolha o primeiro numero");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Escolha o segundo numero");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Escolha o sinal que voce gostaria de fazer + - * / ^ \n Aperte 6 Para sair ");
        sinal = Console.ReadLine();
        switch (sinal)
        {
            case "*":
                resultado = n1 * n2;
                break;
            case "+":
                resultado = n1 + n2;
                break;
            case "-":
                resultado = n1 - n2;
                break;
            case "/":
                resultado = n1 / n2;
                break;
            case "^":
                resultado = Math.Pow(n1, n2);
                break;
            case "6":
                cont = 1;
                break;
            default:

                break;
        }
        if (cont != 1)
        {
            Console.WriteLine("O Resultado de " + n1 + " " + sinal + " " + n2 + " é " + resultado);
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Erro \n Pressione uma tecla para tentar novamente");
        Console.ReadKey();
        n1 = 0;
        n2 = 0;
        sinal = "";
        throw;
    }
}

