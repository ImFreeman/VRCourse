using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManger : MonoBehaviour
{
    [SerializeField] private float _startSpawnDelay;
    [SerializeField] private float _deltaSpawnDelay;
    [SerializeField] private float _edgeTimeDelay;

    [SerializeField] private EnemySpawnerData[] _spawners; 

    private float _currentSpawnDelay;
    private float _currentGlobalTime;
    private float _currentEnemySpawnTime;

    private bool _isActive;

    private System.Random _random;

    public void StartSpawn()
    {
        _isActive = true;
    }

    public void StopSpawn()
    {
        _isActive = false;
    }
    
    private void Awake()
    {
        _currentSpawnDelay = _startSpawnDelay;
        _random = new System.Random();
    }

    private void Update()
    {
        if (!_isActive)
        {
            return;
        }
        _currentEnemySpawnTime += Time.deltaTime;
        if (_currentEnemySpawnTime >= _currentSpawnDelay)
        {
            int spawnerId = _random.Next(_spawners.Length);
            _spawners[spawnerId].Spawner.SpawnEnemy(_spawners[spawnerId].SpawnPoint);
            _currentEnemySpawnTime = 0f;
        }

        _currentGlobalTime += Time.deltaTime;
        if (_currentGlobalTime >= _edgeTimeDelay)
        {
            _currentGlobalTime = 0f;
            _currentSpawnDelay -= _deltaSpawnDelay;
        }
    }

    [Serializable]
    private struct EnemySpawnerData
    {
        public EnemySpawner Spawner;
        public Vector3 SpawnPoint;
    }
}