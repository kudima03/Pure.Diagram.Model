using Pure.Diagram.Model.Abstractions;

namespace Pure.Diagram.Model.Tests;

public sealed record DonutDiagramTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IDiagramType type = new DonutDiagramType();

        Assert.Equal("donut", type.Name.TextValue);
    }
}
