using System.Collections;
using VRBuilder.Core;

namespace VR_Builder_extentsion.StringPropertyTransition
{
    public class StringValueConditionProcess : StageProcess<StringValueConditionData>
    {
        public StringValueConditionProcess(StringValueConditionData data, IEntity outer = null) : base(data, outer)
        {
        }

        public override void Start()
        {
            Data.ValuePropertyReference.Value.PropertyValue = string.Empty;
        }

        public override IEnumerator Update()
        {
            while (true)
            {
                Data.IsCompleted = Data.TargetValue.Equals(Data.ValuePropertyReference.Value.PropertyValue);

                yield return null;
            }
        }

        public override void End()
        {
            
        }

        public override void FastForward()
        {
            
        }
    }
}