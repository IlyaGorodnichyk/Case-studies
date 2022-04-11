using Using_delegate; 

Calculate calculate = new Calculate();
calculate.RegistrMetod(PrintNotificatoin); //Add metod to delegate
calculate.Add(-1, 5);
calculate.RegistrMetod(PrintColorText); //Add metod to delegate
calculate.Multiply(3, 5);
calculate.UnregisterMetod(PrintColorText);
calculate.Dividsion(46, 87);


void PrintNotificatoin(string messege) => Console.WriteLine(messege);
void PrintColorText(string messege) 
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(messege);
    Console.ResetColor();
}
