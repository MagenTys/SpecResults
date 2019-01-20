using System;
using System.Threading.Tasks;

namespace SpecNuts
{
	public abstract class ReportingStepDefinitions : ContextBoundObject
	{
		public async Task ReportStep(Func<Task> stepFunc, params object[] args)
		{
			await Reporters.ExecuteStep(stepFunc, args);
		}
	}
}