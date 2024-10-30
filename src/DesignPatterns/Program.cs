using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Utils.Display;
using Spectre.Console;

MainTitle();

// Loading screen
ShowLoadingScreen("Loading...", "TTD Consulting", 1500, 2000);

var patternGroups = new Dictionary<string, Dictionary<string, Action>>
{
    {
        "Creational", new Dictionary<string, Action>
        {
            { "Factory Method", RunFactoryMethod },
            { "Abstract Factory", RunAbstractFactory },
            { "Builder", RunBuilderFactory },
            { "Prototype", RunPrototypeFactory },
            { "Singleton", RunSingletonFactory }
        }
    },
    {
        "Structural", new Dictionary<string, Action>
        {
            { "Adapter", RunAdapterFactory },
            { "Bridge", RunBridgeFactory },
            { "Flyweight", RunFlyweightFactory },
            { "Composite", RunCompositeFactory },
            { "Decorator", RunDecoratorFactory },
            { "Facade", RunFacadeFactory },
        }
    },
    {
        "Behavioral", new Dictionary<string, Action>
        {
            { "ChainOfResponsibility", RunChainOfResponsibilityFactory },
        }
    }
};

bool exit = false;

while (!exit)
{
    Console.Clear();
    MainTitle();

    // First menu: Choose a pattern group (Creational/Structural)
    var groupChoice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Please choose a pattern group:")
            .PageSize(10)
            .AddChoices(patternGroups.Keys.Append("Exit").ToArray()));

    if (groupChoice == "Exit")
    {
        exit = true;
    }
    else if (patternGroups.ContainsKey(groupChoice))
    {
        // Second menu: Choose a specific pattern within the chosen group
        var patternChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"Please choose a {groupChoice} pattern to run:")
                .PageSize(10)
                .AddChoices(patternGroups[groupChoice].Keys.Append("Back").ToArray()));

        if (patternChoice == "Back")
        {
            continue;
        }
        else if (patternGroups[groupChoice].ContainsKey(patternChoice))
        {
            patternGroups[groupChoice][patternChoice]();
        }
        else
        {
            AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
        }
    }
    else
    {
        AnsiConsole.Markup("[red]Invalid option, please try again.[/]");
    }
}

AnsiConsole.Markup("[green]See you soon. Goodbye![/]");

// Utility methods
void MainTitle()
{
    AnsiConsole.Write(
        new FigletText("Design Patterns")
            .Centered()
            .Color(Color.Cyan1));
}

void ShowLoadingScreen(string initialMessage, string statusMessage, int initialDelay, int finalDelay)
{
    AnsiConsole.Status()
        .Start(initialMessage, ctx =>
        {
            Thread.Sleep(initialDelay);
            ctx.Status(statusMessage);
            ctx.Spinner(Spinner.Known.Star);
            ctx.SpinnerStyle(Style.Parse("green"));
            AnsiConsole.MarkupLine("Loading...");
            Thread.Sleep(finalDelay);
        });
}

// IPattern-specific run methods
void RunFactoryMethod()
{
    RunPattern(new FactoryMethod(new ConsoleOutput()), "Please choose type of insurance policy:", new[] { "Health", "Life", "Vehicle" });
}

void RunAbstractFactory()
{
    RunPattern(new AbstractFactory(new ConsoleOutput()), "Please choose type of insurance policy:", new[] { "Individual", "Corporate" });
}

void RunBuilderFactory()
{
    RunPattern(new Builder(new ConsoleOutput()), "Please choose type of insurance policy:", new[] { "Comprehensive", "Basic" });
}

void RunPrototypeFactory()
{
    RunPattern(new Prototype(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunSingletonFactory()
{
    RunPattern(new Singleton(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunAdapterFactory()
{
    RunPattern(new Adapter(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunBridgeFactory()
{
    RunPattern(new Bridge(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunFlyweightFactory()
{
    RunPattern(new Flyweight(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunCompositeFactory()
{
    RunPattern(new Composite(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunDecoratorFactory()
{
    RunPattern(new Decorator(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunChainOfResponsibilityFactory()
{
    RunPattern(new ChainOfResponsibility(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

void RunFacadeFactory()
{
    RunPattern(new Facade(new ConsoleOutput()), "Please choose option:", new[] { "Start" });
}

// Helper method to generalize pattern execution
void RunPattern(object pattern, string promptTitle, string[] options)
{
    bool exit = false;
    while (!exit)
    {
        var option = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title(promptTitle)
                .PageSize(10)
                .AddChoices(options.Append("Exit").ToArray()));

        if (option.ToLower() == "exit")
        {
            exit = true;
        }
        else
        {
            dynamic dynamicPattern = pattern;
            if (string.IsNullOrEmpty(option))
            {

                dynamicPattern.Run(option);
            }
            else
            {
                dynamicPattern.Run();
            }
        }
    }
}
