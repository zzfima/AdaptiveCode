using AOPExample.BL;

AgeCalculatorNoAOP ageCalculatorNoAOP = new AgeCalculatorNoAOP();
Console.WriteLine(ageCalculatorNoAOP.Add(5, 6));

Console.WriteLine();

AgeCalculatorAOP ageCalculatorAOP = new AgeCalculatorAOP();
Console.WriteLine(ageCalculatorAOP.Add(5, 6));

Console.ReadLine();