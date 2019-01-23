using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecNuts
{
	public abstract class ReportingStepDefinitions : ContextBoundObject
	{
		public async Task ReportStep(ScenarioContext scenarioContext, Func<Task> stepFunc, params object[] args)
		{
			await Reporters.ExecuteStep(scenarioContext, stepFunc, args);
		}
	}
}