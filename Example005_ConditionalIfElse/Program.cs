Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "ева")
{
    Console.WriteLine("Ура, это же Ева!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}