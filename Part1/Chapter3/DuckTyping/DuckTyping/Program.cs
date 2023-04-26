using ImpromptuInterface;

var swan = new Swan();

//NO DUCK TYPING
var swanAsDuck = swan as IDuck;

if (swan is IDuck || swanAsDuck != null)
{
    Console.WriteLine("*** Is a IDuck!");
    swanAsDuck?.Walk();
    swanAsDuck?.Swim();
    swanAsDuck?.Quack();
}
else
{
    Console.WriteLine("*** Is not a IDuck :-(");
}

//DUCK TYPING using DYNAMIC
DoDuckLickeThings(swan);

void DoDuckLickeThings(dynamic duck)
{
    Console.WriteLine("*** Is a IDuck using dynamic!");
    duck?.Walk();
    duck?.Swim();
    duck?.Quack();
}

//DUCK TYPING using Impromptu

var myDuck = Impromptu.ActLike<IDuck>(swan);

if (myDuck is IDuck)
{
    Console.WriteLine("*** Is a IDuck Impromptu!");
    myDuck?.Walk();
    myDuck?.Swim();
    myDuck?.Quack();
}
else
{
    Console.WriteLine("Is not a IDuck :-(");
}

Console.ReadLine();