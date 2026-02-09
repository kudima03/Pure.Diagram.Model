using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model;

public sealed record DiagramType : IDiagramType
{
    public DiagramType(IString name)
    {
        Name = name;
    }

    public IString Name { get; }
}
