using Xunit;

namespace GitTools.Testing.Tests
{
    public class Example
    {
        [Fact]
        public void TheReadmeSample()
        {
            using (var fixture = new EmptyRepositoryFixture())
            {
                fixture.MakeACommit();
                fixture.MakeACommit();
                fixture.MakeATaggedCommit("1.0.0");
                fixture.BranchTo("develop");
                fixture.MakeACommit();
                fixture.Checkout("master");
                fixture.MergeNoFF("develop");
            }
        }
    }
}