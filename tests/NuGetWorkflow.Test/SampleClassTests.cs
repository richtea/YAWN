using FluentAssertions;

namespace NuGetWorkflow.Test;


public class SampleClassTests
{
    [Fact]
    public void can_get_a_number()
    {
        // *** ARRANGE ***
        var sut = new SampleClass();

        // *** ACT ***
        var result = sut.GetANumber();

        // *** ASSERT ***
        result.Should().Be(2);
    }
}
