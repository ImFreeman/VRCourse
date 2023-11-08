using System.Runtime.Serialization;
using VRBuilder.Core;
using VRBuilder.Core.Conditions;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
public class FloatValueConditionData : IConditionData
{
    [DataMember] 
    public ScenePropertyReference<FloatValueProperty> ValuePropertyReference { get; set; }
    [DataMember]
    public float TargetValue { get; set; }
    public Metadata Metadata { get; set; }
    public bool IsCompleted { get; set; }
    public string Name { get; }
}