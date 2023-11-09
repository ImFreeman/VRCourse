using System;
using Features.Enemy.Scripts;
using Unity.VisualScripting;
using UnityEngine;

namespace Features.Weapon.Scripts
{
    public class WeaponHitHandler : MonoBehaviour
    {
        [SerializeField] private EnemyStorage _storage;
        [SerializeField] private EnemyController _enemyController;
        [SerializeField] private WeaponView _weapon;

        private void OnEnable()
        {
            _weapon.EnemyHitEvent += OnEnemyHitEvent;
        }

        private void OnEnemyHitEvent(object sender, int e)
        {
            _enemyController.UnhandleEnemy(e);
            _storage.DeleteEnemy(e);
        }

        private void OnDisable()
        {
            _weapon.EnemyHitEvent -= OnEnemyHitEvent;
        }
    }
}