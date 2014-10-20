using TechTalk.SpecFlow;

namespace SpecFlowExtension
{
    public static class SpecFlowExtensionMethods
    {
        public static void RemoveIfExists(this ScenarioContext scenarioContext, string key)
        {
            if (scenarioContext.ContainsKey(key))
            {
                scenarioContext.Remove(key);
            }
        }

        public static void AddNewRemoveExisting(this ScenarioContext scenarioContext, string key, object @object)
        {
            if (scenarioContext.ContainsKey(key))
            {
                scenarioContext.Remove(key);
            }
            scenarioContext.Add(key, @object);
        }
    }
}