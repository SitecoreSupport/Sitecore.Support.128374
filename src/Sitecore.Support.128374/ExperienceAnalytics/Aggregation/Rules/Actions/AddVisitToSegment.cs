namespace Sitecore.Support.ExperienceAnalytics.Aggregation.Rules.Actions
{
    using Sitecore.Rules;
    using Sitecore.Rules.Actions;

    public class AddVisitToSegment<T> : RuleAction<T>
      where T : RuleContext
    {
        public override void Apply(T ruleContext)
        {
            ruleContext.Parameters.Add("addVisit", true);
        }
    }
}