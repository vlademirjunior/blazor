namespace FrontEnd.ContainerDI;

public class ScopedService : IScopedService
{
    private readonly Guid _operationID;

    public ScopedService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}
