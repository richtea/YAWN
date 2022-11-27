using FluentAssertions;

namespace NuGetWorkflow.Test;

public class SampleClassTests
{
    [Fact]
    public void can_get_a_number()
    {
        var sut = new SampleClass();

        var result = sut.GetANumber();

        result.Should().Be(2);
    }
}