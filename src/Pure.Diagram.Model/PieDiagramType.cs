using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.Model;

public sealed record PieDiagramType : IDiagramType
{
    public IString Name { get; } = new String("pie");
}
