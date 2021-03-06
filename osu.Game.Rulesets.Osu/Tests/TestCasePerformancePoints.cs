// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using NUnit.Framework;

namespace osu.Game.Rulesets.Osu.Tests
{
    [Ignore("getting CI working")]
    public class TestCasePerformancePoints : Game.Tests.Visual.TestCasePerformancePoints
    {
        public TestCasePerformancePoints()
            : base(new OsuRuleset(new RulesetInfo()))
        {
        }
    }
}
