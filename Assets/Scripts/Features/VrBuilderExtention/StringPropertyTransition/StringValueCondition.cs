using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnityEngine.Scripting;
using VR_Builder_extentsion.StringPropertyTransition;
using VRBuilder.Core;
using VRBuilder.Core.Conditions;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
public class StringValueCondition : Condition<StringValueConditionData>
{
    public StringValueCondition(string valueProperty, string targetValue)
    {
        Data.ValuePropertyReference = new ScenePropertyReference<StringValueProperty>(valueProperty);
        Data.TargetValue = targetValue;
    }
    
    [JsonConstructor, Preserve]
    public StringValueCondition() : this("", "hello")
    {
    }
    
    public override IStageProcess GetActiveProcess()
    {
        return new StringValueConditionProcess(Data);
    }
}
