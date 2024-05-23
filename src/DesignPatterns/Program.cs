
using DesignPatterns.Creational.FactoryMethod;
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
                "Factory Method", "Exit"
            }));

    switch (choice)
    {
        case "Factory Method":

            var runFactoryMethodExample = new RunFactoryMethodExample();
            runFactoryMethodExample.Run();

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
