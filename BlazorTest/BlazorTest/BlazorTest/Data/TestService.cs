namespace BlazorTest.Data
{
    public class TestService
    {
        public Task<string> GetTestString()
        {
            return Task.FromResult("Moo");
        }
    }
}