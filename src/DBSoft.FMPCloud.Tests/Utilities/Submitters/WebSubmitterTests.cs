using DBSoft.FMPCloud.Utilities.Submitters;

namespace DBSoft.FMPCloud.Tests.Utilities.Submitters
{

    public class FormatDestinationData : TheoryData<string, Dictionary<string, string>, string>
    {
        public FormatDestinationData()
        {
            Add("test1", new Dictionary<string, string> { { "key1", "val1" } }, "test1?key1=val1");
            Add("test2", new Dictionary<string, string> { { "key1", "val1" }, { "key2", "val2" }, { "key3", "val3" } }, "test2?key1=val1&key2=val2&key3=val3");
        }
    }
    public class WebSubmitterTests
    {
        [Theory]
        [ClassData(typeof(FormatDestinationData))]
        public void Test_FormatDestination(string destination, Dictionary<string, string> parameters, string expected)
        {
            var submitter = new WebSubmitter(new Mock<IHttpClientFactory>().Object, new Mock<ILogger<WebSubmitter>>().Object);

            var result = submitter.FormatDestination(destination, parameters);

            Assert.Equal(expected, result);
        }
    }
}
