namespace DesignPatterns.Behavioral.Command;

public class AddPolicyCommand : ICommand
{
    private readonly PolicyService _service;
    private readonly string _id;

    public AddPolicyCommand(PolicyService service, string id)
    {
        _service = service;
        _id = id;
    }

    public string Execute()
    {
        return _service.AddPolicy(_id);
    }
}
