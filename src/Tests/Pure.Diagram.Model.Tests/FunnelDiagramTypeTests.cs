using Pure.Diagram.Model.Abstractions;

namespace Pure.Diagram.Model.Tests;

public sealed record FunnelDiagramTypeTests
{
    [Fact]
    public void ProduceCorrectName()
    {
        IDiagramType type = new FunnelDiagramType();

        Assert.Equal("funnel", type.Name.TextValue);
    }
}
