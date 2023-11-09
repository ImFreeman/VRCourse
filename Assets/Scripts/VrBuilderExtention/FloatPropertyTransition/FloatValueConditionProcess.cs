using System.Collections;
using UnityEngine;
using VRBuilder.Core;

namespace VR_Builder_extentsion.FloatPropertyTransition
{
    public class FloatValueConditionProcess : StageProcess<FloatValueConditionData>
    {
        public FloatValueConditionProcess(FloatValueConditionData data, IEntity outer = null) : base(data, outer)
        {
        }

        public override void Start()
        {
            
        }

        public override IEnumerator Update()
        {
            while (true)
            {
                Data.IsCompleted = Mathf.Abs(Data.TargetValue - Data.ValuePropertyReference.Value.PropertyValue) <= 0.01f;

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