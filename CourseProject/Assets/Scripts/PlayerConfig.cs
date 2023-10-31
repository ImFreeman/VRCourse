using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerConfig", menuName = "ScriptableObjects/PlayerConfig", order = 1)]
public class PlayerConfig : ScriptableObject
{
    [SerializeField] private PlayerView _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _sensivity;


    public PlayerView Player => _player;

    public float Speed => _speed;

    public float Sensivity => _sensivity;
}
