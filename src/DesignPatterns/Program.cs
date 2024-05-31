
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Utils.Display;
using Spectre.Console;


MainTitle();

// Loading
AnsiConsole.Status()
    .Start("Loading...", ctx =>
    {

        AnsiConsole.MarkupLine("Loading...");
        Thread.Sleep(1500);

        ctx.Status("TTD Consulting");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("green"));

        AnsiConsole.MarkupLine("Loading...");
        Thread.Sleep(2000);
    });

var exit = false;

while (!exit)
{
    Console.Clear();

    MainTitle();
    var choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please choose pattern to run:")
            .PageSize(10)
            .AddChoices(new[] {
                "Factory Method","Abstract Factory", "Exit"
            }));

    switch (choice)
    {
        case "Factory Method":
            RunFactoryMethod();
            break;
        case "Abstract Factory":
            RunAbstractFactory();
            break;
        case "Exit":
            exit = true;
            break;
        default:
            AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
            break;
    }

}

AnsiConsole.Markup("[green]See you soon. Goodbye![/]");

void MainTitle()
{
    AnsiConsole.Write(
        new FigletText("Design Patterns")
            .Centered()
            .Color(Color.Cyan1));
}

void RunFactoryMethod()
{
    var runFactoryMethodExample = new FactoryMethod(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var policyType = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Health","Life","Vehicle", "Exit"
                }));
        if (!string.IsNullOrEmpty(policyType))
        {
            if (policyType.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            runFactoryMethodExample.Run(policyType);
        }
    }
}
void RunAbstractFactory()
{
    var abstractFactory = new AbstractFactory(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Individual","Corporate", "Exit"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            abstractFactory.Run(option);
        }
    }
}

