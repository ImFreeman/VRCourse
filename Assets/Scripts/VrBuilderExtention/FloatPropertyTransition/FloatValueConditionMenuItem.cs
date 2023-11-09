using VRBuilder.Core.Conditions;
using VRBuilder.Editor.UI.StepInspector.Menu;

namespace VR_Builder_extentsion.FloatPropertyTransition
{
    public class FloatValueConditionMenuItem : MenuItem<ICondition>
    {
        public override ICondition GetNewItem()
        {
            return new FloatValueCondition();
        }

        public override string DisplayedName => "Conditions/FloatValueCondition";
    }
}