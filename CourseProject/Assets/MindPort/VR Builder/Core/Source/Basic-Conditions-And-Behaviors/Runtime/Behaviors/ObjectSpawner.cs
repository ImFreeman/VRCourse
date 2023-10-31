using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Scripting;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;
using VRBuilder.Core.Behaviors;

public class ObjectSpawner : Behavior<ObjectSpawner.EntityData>
{
    /// <summary>
    /// The data class for a delay behavior.
    /// </summary>
    [DisplayName("Delay")]
    [DataContract(IsReference = true)]
    public class EntityData : IBehaviorData
    {
        [DataMember]
        [DisplayName("Path to prefab")]
        public string Path { get; set; }

        public Metadata Metadata { get; set; }
        public string Name
        {
            get => Path;
        }
    }

    [JsonConstructor, Preserve]
    public ObjectSpawner() : this(0)
    {
    }

    public ObjectSpawner(float delayTime)
    {
        if (delayTime < 0f)
        {
            Debug.LogWarningFormat("DelayTime has to be zero or positive, but it was {0}. Setting to 0 instead.", delayTime);
            delayTime = 0f;
        }

        Data.DelayTime = delayTime;
    }

    private class ActivatingProcess : StageProcess<EntityData>
    {
        public ActivatingProcess(EntityData data) : base(data)
        {
        }

        /// <inheritdoc />
        public override void Start()
        {
        }

        public override IEnumerator Update()
        {
            throw new System.NotImplementedException();
        }

        public override void End()
        {
            throw new System.NotImplementedException();
        }

        public override void FastForward()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <inheritdoc />
    public override IStageProcess GetActivatingProcess()
    {
        return new ActivatingProcess(Data);
    }
}
