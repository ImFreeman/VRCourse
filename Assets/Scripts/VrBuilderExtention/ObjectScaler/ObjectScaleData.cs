using System.Runtime.Serialization;
using UnityEngine;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;
using VRBuilder.Core.Behaviors;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
[DisplayName("ObjectScale")]
public class ObjectScaleData : IBehaviorData
{
    [DataMember]
    public SceneObjectReference Target { get; set; }

    [DataMember] public Vector3 Scale { get; set; }
    
    public Metadata Metadata { get; set; }
    public string Name { get; }
}
