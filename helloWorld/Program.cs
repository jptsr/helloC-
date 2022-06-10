// See https://aka.ms/new-console-template for more information



/*  PRACTICE COMMAND IN CONSOLE  */

Console.WriteLine("Hello, who are you ?");
string pickName = Console.ReadLine();
Console.WriteLine("Hello " + $"{pickName}" + "! How are you ?");
string state = Console.ReadLine();
Console.WriteLine("I feel " + $"{state.ToLower()}" + " as well, " + $"{pickName}" + ".");

Console.WriteLine("When are you born (answer in this format : xx/xx/xxxx) ?");
string datebirth = Console.ReadLine();

DateTime now = DateTime.Now;
string currentDate = now.ToString("dd/MM/yyyy");

int day = Int32.Parse(datebirth.Substring(0, 2));
int month = Int32.Parse(datebirth.Substring(3, 2));
int year = Int32.Parse(datebirth.Substring(6, 4));

int currentDay = Int32.Parse(currentDate.Substring(0, 2));
int currentMonth = Int32.Parse(currentDate.Substring(3, 2));
int currentYear = Int32.Parse(currentDate.Substring(6, 4));

int age = currentYear - year;
bool birthday = false;

if (currentMonth - month > 0)
{
    age = age;
}   
else if (currentMonth - month < 0)
{
    age--;
}
else
{
    if (currentDay - day < 0)
    {
        age--;
    }
    else if (currentDay - day > 0)
    {
        age = age;
    }
    else
    { 
        age = age;
        birthday = true;
    }
}

Console.WriteLine(birthday ? "Wow it's your birthday ! Your're " + $"{age}" + " today, congrats !" : "You are " + $"{age}" + " years old.");