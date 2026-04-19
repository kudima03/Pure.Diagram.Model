using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model;

public sealed record DiagramSeries : IDiagramSeries
{
    public DiagramSeries(IString label, IString source)
    {
        Label = label;
        Source = source;
    }

    public IString Label { get; }

    public IString Source { get; }
}
