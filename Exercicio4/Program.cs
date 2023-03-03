internal class Exercicio4
{
    private static void Main(string[] args)
    {
        //Leia um número qualquer e imprima se ele é primo ou não
        int cont = 0, primo = 0;

        Console.WriteLine("Digite um número para saber se é primo: ");
        double num = double.Parse(Console.ReadLine());

        cont = int.Parse(num.ToString());

        while (cont > 0)
        {
            if(num%cont == 0)
            {
                primo++;
            }
            cont--;
        }
        if(primo == 2)
        {
            Console.WriteLine($"Número {num} é primo.");
        }
        else
        {
            Console.WriteLine($"O número {num} não é primo.");
        }

    }
}