namespace DesignPatterns.Behavioral.Command;

public class RemovePolicyCommand : ICommand
{
    private readonly PolicyService _service;
    private readonly string _id;

    public RemovePolicyCommand(PolicyService service, string id)
    {
        _service = service;
        _id = id;
    }

    public string Execute()
    {
        return _service.RemovePolicy(_id);
    }
}
