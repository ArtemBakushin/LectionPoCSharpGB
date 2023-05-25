Console.Write("Введите имя : ");
string username = Console.ReadLine();
if (username.ToLower() == "Masha")
{
    Console.WriteLine("Ура это же Masha");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}