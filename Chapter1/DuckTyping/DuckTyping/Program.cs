var swan = new Swan();

var swanAsDuck = swan as IDuck;

if (swan is IDuck || swanAsDuck != null)
{
    Console.WriteLine("Is a IDuck!");
    swanAsDuck?.Walk();
    swanAsDuck?.Swim();
    swanAsDuck?.Quack();
}
else
{
    Console.WriteLine("Is not a IDuck :-(");
}

Console.ReadLine();