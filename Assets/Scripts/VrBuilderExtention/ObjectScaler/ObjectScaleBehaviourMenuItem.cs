using VRBuilder.Core.Behaviors;
using VRBuilder.Editor.UI.StepInspector.Menu;

public class ObjectScaleBehaviourMenuItem : MenuItem<IBehavior>
{
    public override IBehavior GetNewItem()
    {
        return new ObjectScaleBehaviour();
    }

    public override string DisplayedName => "CustomBehaviour/ObjectScaler";
}