using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model;

public sealed record Diagram : IDiagram
{
    public Diagram(
        IString title,
        IString description,
        IDiagramType type,
        IEnumerable<ISeries> series
    )
    {
        Title = title;
        Description = description;
        Type = type;
        Series = series;
    }

    public IString Title { get; }

    public IString Description { get; }

    public IDiagramType Type { get; }

    public IEnumerable<ISeries> Series { get; }
}
