double dividendo, divisor, quociente;

Console.WriteLine("--- Divisão ---");

Console.Write("Digite o dividendo...: ");
dividendo = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o divisor.....: ");
divisor = Convert.ToDouble(Console.ReadLine());

bool valid = divisor != 0; 

bool invalid = divisor == 0; 

if(invalid)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Não é possível dividir um número por 0");
    Console.ResetColor();
}

else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    quociente = dividendo / divisor;
    Console.WriteLine($"A divisão de {dividendo:N1} por {divisor:N1} é igual a: {quociente:N1}");
    Console.ResetColor();
}

Console.WriteLine("Obrigado por utilizar essa bomba aqui!");