using Pure.Diagram.Model.Abstractions;

namespace Pure.Diagram.Model.Tests;

public sealed record RoseDiagramTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IDiagramType type = new RoseDiagramType();

        Assert.Equal("rose", type.Name.TextValue);
    }
}
