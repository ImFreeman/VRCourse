using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyStorage _enemyStorage;
    [SerializeField] private EnemyView _enemyViewPrefab;
        
    public int SpawnEnemy(Vector3 position)
    {
        var enemy = GameObject.Instantiate<EnemyView>(_enemyViewPrefab);
        enemy.transform.position = position;
        _enemyStorage.SetEnemy(enemy);
        return enemy.gameObject.GetInstanceID();
    }
}
