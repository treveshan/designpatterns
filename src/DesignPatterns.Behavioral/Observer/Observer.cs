using DesignPatterns.Utils.Display;

namespace DesignPatterns.Behavioral.Observer;

public class Observer
{
    private readonly IOutput _output;

    public Observer(IOutput output)
    {
        _output = output;
    }

    public void Run()
    {
        var subject = new PolicySubject();
        var dep = new DepartmentObserver();
        subject.Attach(dep);

        subject.Notify("A");
        foreach (var msg in dep.Notifications)
            _output.Display(msg);
    }
}
