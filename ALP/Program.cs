Console.WriteLine("Ahoj");
Console.WriteLine("Kolik ti je?");
int vek = Convert.ToInt32(Console.ReadLine());
if (vek >= 18)
{
    Console.WriteLine("si plnoletý a můžeš mít řidičák");
}
if (vek >= 15)
{
    Console.WriteLine("dokončil si základku a máš občanku");
}
if(vek <= 15)
{
    Console.WriteLine("Jsi na základce a nemáš doklady plus jsi kid");
}

