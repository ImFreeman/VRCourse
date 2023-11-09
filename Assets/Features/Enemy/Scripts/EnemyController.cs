using System;
using UnityEngine;

namespace Features.Enemy.Scripts
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private EnemyManager _manager;
        [SerializeField] private EnemyStorage _storage;
        [SerializeField] private Vector3 _endPoint;

        public event EventHandler EnemyEnteredEvent;
        
        private void OnEnable()
        {
            _manager.EnemySpawned += OnEnemySpawned;
        }

        public void UnhandleEnemy(int id)
        {
            _storage.GetEnemy(id).OnEnterEvent -= OnEnemyEnterEvent;
        }

        private void OnEnemySpawned(object sender, int e)
        {
            var enemy = _storage.GetEnemy(e);
            if (enemy != null)
            {
                enemy.MeshAgent.SetDestination(_endPoint);
                enemy.OnEnterEvent += OnEnemyEnterEvent;
            }
        }

        private void OnEnemyEnterEvent(object sender, GameObject e)
        {
            if (e.CompareTag("Finish"))
            {
                var enemy = sender as EnemyView;
                enemy.OnEnterEvent -= OnEnemyEnterEvent;
                _storage.DeleteEnemy(enemy.gameObject.GetInstanceID());
                EnemyEnteredEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnDisable()
        {
            _manager.EnemySpawned -= OnEnemySpawned;
        }
    }
}