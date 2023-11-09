using VRBuilder.Core.Conditions;
using VRBuilder.Editor.UI.StepInspector.Menu;

namespace VR_Builder_extentsion.StringPropertyTransition
{
    public class StringValueConditionMenuItem : MenuItem<ICondition>
    {
        public override ICondition GetNewItem()
        {
            return new StringValueCondition();
        }

        public override string DisplayedName => "Conditions/StringValueCondition";
    }
}