using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStorage : MonoBehaviour
{
    private Dictionary<int, EnemyView> _dictionary;

    private void Awake()
    {
        _dictionary = new Dictionary<int, EnemyView>();
    }

    public void SetEnemy(EnemyView enemyView)
    {
        _dictionary.TryAdd(enemyView.gameObject.GetInstanceID(), enemyView);
    }
    
    public EnemyView GetEnemy(int id)
    {
        _dictionary.TryGetValue(id, out var view);
        return view;
    }

    public void DeleteEnemy(int id)
    {
        _dictionary.TryGetValue(id, out var view);
        if (view != null)
        {
            Destroy(view.gameObject);
            _dictionary.Remove(id);
        }
    }

    public void Clear()
    {
        foreach (var key in _dictionary.Keys)
        {
            DeleteEnemy(key);
        }
    }
}