using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnityEngine.Scripting;
using VR_Builder_extentsion.FloatPropertyTransition;
using VRBuilder.Core;
using VRBuilder.Core.Conditions;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
public class FloatValueCondition : Condition<FloatValueConditionData>
{
    public FloatValueCondition(string valueProperty, float targetValue)
    {
        Data.ValuePropertyReference = new ScenePropertyReference<FloatValueProperty>(valueProperty);
        Data.TargetValue = targetValue;
    }
    
    [JsonConstructor, Preserve]
    public FloatValueCondition() : this("", 0f)
    {
    }
    
    public override IStageProcess GetActiveProcess()
    {
        return new FloatValueConditionProcess(Data);
    }
}