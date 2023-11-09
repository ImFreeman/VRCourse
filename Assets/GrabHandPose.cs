using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabHandPose : MonoBehaviour
{
    public HandData rightHandpose;

    private Vector3 startingHandPosition;
    private Vector3 finalHandPosition;
    private Quaternion startingHandRotation;
    private Quaternion finalHandRotation;

    private Quaternion[] startingFingerRotations;
    private Quaternion[] finalFingerRotations;
    
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(SetupPose);
        grabInteractable.selectExited.AddListener(UnSetupPose);
        rightHandpose.gameObject.SetActive(false);
    }

    void UnSetupPose(BaseInteractionEventArgs arg)
    {
        if (arg.interactorObject is XRDirectInteractor)
        {
            HandData handData = arg.interactorObject.transform.GetComponentInChildren<HandData>();
            handData.Animator.enabled = true;
        }
    }
    
    void SetupPose(BaseInteractionEventArgs arg)
    {
        if (arg.interactorObject is XRDirectInteractor)
        {
            HandData handData = arg.interactorObject.transform.GetComponentInChildren<HandData>();
            handData.Animator.enabled = false;
            
            SetHandDataValues(handData, rightHandpose);
            SetHandData(handData, finalHandPosition, finalHandRotation, finalFingerRotations);
        }
    }

    public void SetHandDataValues(HandData h1, HandData h2)
    {
        startingHandPosition = h1.Root.localPosition;
        finalHandPosition = h2.Root.localPosition;

        startingHandRotation = h1.Root.localRotation;
        finalHandRotation = h2.Root.localRotation;

        startingFingerRotations = new Quaternion[h1.FingerBones.Length];
        finalFingerRotations = new Quaternion[h1.FingerBones.Length];

        for (int i = 0; i < h1.FingerBones.Length; i++)
        {
            startingFingerRotations[i] = h1.FingerBones[i].localRotation;
            finalFingerRotations[i] = h2.FingerBones[i].localRotation;
        }
    }

    public void SetHandData(HandData h, Vector3 newPosition, Quaternion newRotation, Quaternion[] newBonesRotation)
    {
        h.Root.localPosition = newPosition;
        h.Root.localRotation = newRotation;

        for (int i = 0; i < newBonesRotation.Length; i++)
        {
            h.FingerBones[i].localRotation = newBonesRotation[i];
        }
    }
}
