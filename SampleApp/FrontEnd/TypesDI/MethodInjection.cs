namespace FrontEnd.TypesDI;

using FrontEnd.ContainerDI;

public class MethodInjection
{
    public void DoSomething(ISingletonService dependency)
    {
        dependency.GetOperationID();
    }
}
// Dependencies are passed as method parameters.
// This can be useful in scenarios where dependencies are only needed for specific methods.
