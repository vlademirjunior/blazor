namespace FrontEnd.ContainerDI;

public class TransientService : ITransientService
{
    private readonly Guid _operationID;

    public TransientService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}
