using Pure.Diagram.Model.Abstractions;

namespace Pure.Diagram.Model.Tests;

public sealed record PieDiagramTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IDiagramType type = new PieDiagramType();

        Assert.Equal("pie", type.Name.TextValue);
    }
}
