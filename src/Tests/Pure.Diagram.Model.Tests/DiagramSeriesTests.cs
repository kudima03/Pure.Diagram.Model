using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Diagram.Model.Tests;

public sealed record DiagramSeriesTests
{
    [Fact]
    public void InitializeLabelCorrectly()
    {
        IString label = new RandomString();

        IDiagramSeries series = new DiagramSeries(label, new RandomString());

        Assert.Equal(label.TextValue, series.Label.TextValue);
    }

    [Fact]
    public void InitializeSourceCorrectly()
    {
        IString source = new RandomString();

        IDiagramSeries series = new DiagramSeries(new RandomString(), source);

        Assert.Equal(source.TextValue, series.Source.TextValue);
    }
}
