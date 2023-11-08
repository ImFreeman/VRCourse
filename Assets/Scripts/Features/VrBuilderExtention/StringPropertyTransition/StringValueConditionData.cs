using System.Runtime.Serialization;
using VRBuilder.Core;
using VRBuilder.Core.Conditions;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
public class StringValueConditionData : IConditionData
{
    [DataMember] 
    public ScenePropertyReference<StringValueProperty> ValuePropertyReference { get; set; }
    [DataMember]
    public string TargetValue { get; set; }
    public Metadata Metadata { get; set; }
    public bool IsCompleted { get; set; }
    public string Name { get; }
}