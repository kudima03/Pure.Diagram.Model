using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Diagram.Model.Tests;

public sealed record DiagramTests
{
    [Fact]
    public void InitializeTitleCorrectly()
    {
        IString title = new RandomString();

        IDiagram diagram = new Diagram(
            title,
            new RandomString(),
            new DiagramType(new RandomString()),
            [
                new Series(new RandomString(), new RandomString()),
                new Series(new RandomString(), new RandomString()),
            ]
        );

        Assert.Equal(title.TextValue, diagram.Title.TextValue);
    }

    [Fact]
    public void InitializeDescriptionCorrectly()
    {
        IString description = new RandomString();

        IDiagram diagram = new Diagram(
            new RandomString(),
            description,
            new DiagramType(new RandomString()),
            [
                new Series(new RandomString(), new RandomString()),
                new Series(new RandomString(), new RandomString()),
            ]
        );

        Assert.Equal(description.TextValue, diagram.Description.TextValue);
    }

    [Fact]
    public void InitializeTypeCorrectly()
    {
        IDiagramType type = new DiagramType(new RandomString());

        IDiagram diagram = new Diagram(
            new RandomString(),
            new RandomString(),
            type,
            [
                new Series(new RandomString(), new RandomString()),
                new Series(new RandomString(), new RandomString()),
            ]
        );

        Assert.Equal(type, diagram.Type);
    }

    [Fact]
    public void InitializeSeriesCorrectly()
    {
        IEnumerable<ISeries> series =
        [
            new Series(new RandomString(), new RandomString()),
            new Series(new RandomString(), new RandomString()),
        ];

        IDiagram diagram = new Diagram(
            new RandomString(),
            new RandomString(),
            new DiagramType(new RandomString()),
            series
        );

        Assert.True(series.SequenceEqual(diagram.Series));
    }
}
