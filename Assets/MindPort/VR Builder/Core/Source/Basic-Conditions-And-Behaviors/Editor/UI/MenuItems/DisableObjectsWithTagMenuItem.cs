using VRBuilder.Core.Behaviors;
using VRBuilder.Editor.UI.StepInspector.Menu;

namespace VRBuilder.Editor.UI.Behaviors
{
    /// <inheritdoc />
    public class DisableObjectsWithTagMenuItem : MenuItem<IBehavior>
    {
        /// <inheritdoc />
        public override string DisplayedName { get; } = "Environment/Disable Objects/By Tag";

        /// <inheritdoc />
        public override IBehavior GetNewItem()
        {
            return new SetObjectsWithTagEnabledBehavior(false);
        }
    }
}
