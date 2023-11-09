using System.Runtime.Serialization;
using UnityEngine;
using VRBuilder.Core;
using VRBuilder.Core.Behaviors;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
public class ObjectScaleBehaviour : Behavior<ObjectScaleData>
{
    public ObjectScaleBehaviour()
    {
        Data.Scale = Vector3.one;
        Data.Target = new SceneObjectReference("");
    }
    
    public override IStageProcess GetActivatingProcess()
    {
        return new ObjectScaleProcess(Data);
    }
}
