namespace Neural4D.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Neural4DClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("NEURAL4D_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("NEURAL4D_API_KEY environment variable is not found.");

        var client = new Neural4DClient(apiKey);
        
        return client;
    }
}
