using System;
using UnityEngine;

namespace Features.Enemy.Scripts
{
    public class EnemySystemStartup : MonoBehaviour
    {
        [SerializeField] private EnemyManager _manager;
        private void OnEnable()
        {
            _manager.StartSpawn();
        }

        private void OnDisable()
        {
            _manager.StopSpawn();
        }
    }
}