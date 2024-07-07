namespace FrontEnd.TypesDI;

using FrontEnd.ContainerDI;

public class PropertyInjection
{
    public ISingletonService Dependency { get; set; } = default!;

    public void DoSomething()
    {
        Dependency.GetOperationID();
    }
}


/*
Aqui temos uma propriedade chamada Dependency na classe PropertyInjection.cs. Essa propriedade é do tipo ISingletonService, que é uma interface.

A propriedade Dependency é uma propriedade de injeção de dependência. A injeção de dependência é um padrão de design amplamente utilizado em desenvolvimento de software, onde as dependências de um objeto são fornecidas externamente, em vez de serem criadas internamente pelo próprio objeto. Isso permite que o objeto seja desacoplado de suas dependências e facilmente substituído ou testado.

Nesse caso, a propriedade Dependency está sendo injetada com uma instância de ISingletonService. A injeção de dependência pode ser feita de várias maneiras, mas aqui está sendo usada a injeção de dependência por propriedade. Isso significa que a dependência é fornecida por meio de uma propriedade pública na classe.

A propriedade Dependency também tem um valor padrão definido como default!. O operador ! é usado para indicar que o valor padrão é nulo, mas não pode ser acessado como nulo. Isso é conhecido como "null-forgiving operator" e é usado para evitar erros de referência nula durante a compilação.

Em resumo, a propriedade Dependency é uma propriedade de injeção de dependência que recebe uma instância de ISingletonService e tem um valor padrão definido como nulo, mas não acessível como nulo. Isso permite que a dependência seja fornecida externamente e facilita a substituição ou teste do objeto que possui essa propriedade.

Dependencies are set via public properties. This approach is less favored because it makes the dependencies less obvious and harder to enforce immutability.
*/
