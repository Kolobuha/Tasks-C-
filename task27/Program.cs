// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int UserNumber = 0;
int sum = 0;	

Console.WriteLine("Введите  число " );	 
UserNumber = Convert.ToInt32(Console.ReadLine());


	  	  
while (UserNumber > 0)

        {
	        sum = sum + UserNumber % 10;
	        UserNumber = UserNumber / 10;
	    }	
    
    Console.WriteLine($" Сумма цифр числа  {sum}");

