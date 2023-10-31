using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private CharacterMovement _characterMovement;
    [SerializeField] private CameraMovement _cameraMovement;

    public CharacterMovement CharacterMovement => _characterMovement;

    public CameraMovement CameraMovement => _cameraMovement;
}
