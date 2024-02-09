namespace avarageNumbers;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;
        int counter = 0;
        double avarage = 0;

        Console.WriteLine("Olá, por gentileza, digite alguns números. E quando desejar encerrar e calcular a média, digite -1.");

    do{
        Console.WriteLine("Digite um número: ");
        number = Convert.ToInt32(Console.ReadLine());            
            if(number != -1){
            sum += number;                 
            counter ++;
        }            
    }while(number != -1);

    avarage = sum / counter;

    Console.WriteLine($"Você digitou {counter} números e a média deles é de {avarage}.");
    }

}

