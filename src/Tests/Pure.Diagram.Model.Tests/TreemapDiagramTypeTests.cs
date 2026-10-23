using Pure.Diagram.Model.Abstractions;

namespace Pure.Diagram.Model.Tests;

public sealed record TreemapDiagramTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IDiagramType type = new TreemapDiagramType();

        Assert.Equal("treemap", type.Name.TextValue);
    }
}
