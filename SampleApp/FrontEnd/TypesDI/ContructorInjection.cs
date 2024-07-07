namespace FrontEnd.TypesDI;

using FrontEnd.ContainerDI;

public class ConstructorInjeciton
{
    private readonly ISingletonService _singletonService;

    public ConstructorInjeciton(ISingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    public void DoSomething()
    {
        _singletonService.GetOperationID();
    }
}
