﻿using SpecFlow.Reporting.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.Reporting.Tests
{
	public partial class StepDefinitions
	{
		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			TextReporter.Enabled = true;
		}
	}
}
