using AOPExample.BL;

Console.WriteLine("No AOP");
AgeCalculatorNoAOP ageCalculatorNoAOP = new AgeCalculatorNoAOP();
Console.WriteLine(ageCalculatorNoAOP.Add(5, 6));
Console.WriteLine(ageCalculatorNoAOP.Sub(5, 6));

Console.WriteLine();

Console.WriteLine("AOP");
AgeCalculatorAOP ageCalculatorAOP = new AgeCalculatorAOP();
Console.WriteLine(ageCalculatorAOP.Add(5, 6));
Console.WriteLine(ageCalculatorAOP.Sub(5, 6));

Console.ReadLine();