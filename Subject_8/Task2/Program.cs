using Spectre.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Position director = Position.Director;
            Position manager = Position.Manager;
            Position engineer = Position.Engineer;
            Position clerk = Position.Clerk;
            Position janitor = Position.Janitor;

            AnsiConsole.MarkupLine($"Директор должен отработать [green]{(int)director}[/] часов в месяц.");
            AnsiConsole.MarkupLine($"Менеджер должен отработать [green]{(int)manager}[/] часов в месяц.");
            AnsiConsole.MarkupLine($"Инженер должен отработать [green]{(int)engineer}[/] часов в месяц.");
            AnsiConsole.MarkupLine($"Клерк должен отработать [green]{(int)clerk}[/] часов в месяц.");
            AnsiConsole.MarkupLine($"Уборщик должен отработать [green]{(int)janitor}[/] часов в месяц.");

            AnsiConsole.Ask<string>("");
        }
    }
}
