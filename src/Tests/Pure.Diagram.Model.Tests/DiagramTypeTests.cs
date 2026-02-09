using Pure.Diagram.Model.Abstractions;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;

namespace Pure.Diagram.Model.Tests;

public sealed record DiagramTypeTests
{
    [Fact]
    public void InitializeNameCorrectly()
    {
        IString name = new RandomString();

        IDiagramType type = new DiagramType(name);

        Assert.Equal(name.TextValue, type.Name.TextValue);
    }
}
