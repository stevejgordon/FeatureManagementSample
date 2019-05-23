
namespace FeatureManagementSample.Models
{
    public class IndexViewModel
    {
        public IndexViewModel(bool greetingGreetingEnabled)
        {
            GreetingEnabled = greetingGreetingEnabled;
        }

        public string Greeting => "Hello from the greeting feature!";

        public bool GreetingEnabled { get; }
    }
}