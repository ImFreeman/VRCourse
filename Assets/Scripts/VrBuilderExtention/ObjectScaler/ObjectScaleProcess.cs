using VRBuilder.Core;

public class ObjectScaleProcess : InstantProcess<ObjectScaleData>
{
    public ObjectScaleProcess(ObjectScaleData data) : base(data)
    {
    }

    public override void Start()
    {
        Data.Target.Value.GameObject.transform.localScale = Data.Scale;
    }
}