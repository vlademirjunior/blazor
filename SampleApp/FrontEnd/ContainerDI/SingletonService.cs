namespace FrontEnd.ContainerDI;

public class SingletonService : ISingletonService
{
    private readonly Guid _operationID;

    public SingletonService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}
