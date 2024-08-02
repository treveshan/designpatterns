
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Utils.Display;
using Spectre.Console;


MainTitle();

// Loading
AnsiConsole.Status()
    .Start("Loading...", ctx =>
    {
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
    //var rule = new Rule("[red]Creational[/]");
    //rule.Justification = Justify.Center;
    //AnsiConsole.Write(rule);

    var choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please choose pattern to run:")
            .PageSize(10)
            .AddChoices(new[] {
                "Factory Method","Abstract Factory","Builder","Prototype","Singleton","Adapter", "Exit"
            }));

    switch (choice)
    {
        case "Factory Method":
            RunFactoryMethod();
            break;
        case "Abstract Factory":
            RunAbstractFactory();
            break;
        case "Builder":
            RunBuilderFactory();
            break;
        case "Prototype":
            RunPrototypeFactory();
            break;
        case "Singleton":
            RunSingletonFactory();
            break;
        case "Adapter":
            RunAdapterFactory();
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
void RunBuilderFactory()
{
    var builder = new Builder(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose type of insurance policy:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Comprehensive","Basic", "Exit"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            builder.Run(option);
        }
    }
}

void RunPrototypeFactory()
{
    var prototype = new Prototype(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start", "Exit"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            prototype.Run();
        }
    }
}
void RunSingletonFactory()
{
    var singleton = new Singleton(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start", "Exit"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            singleton.Run();
        }
    }
}
void RunAdapterFactory()
{
    var adapter = new Adapter(new ConsoleOutput());
    var exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Please choose option:")
                .PageSize(10)
                .AddChoices(new[] {
                    "Start", "Exit"
                }));
        if (!string.IsNullOrEmpty(option))
        {
            if (option.ToLower() == "exit")
            {
                exit = true;
                break;
            }
            adapter.Run();
        }
    }
}

