using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyView : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private Animator _animator;

    public event EventHandler<GameObject> OnEnterEvent; 

    public Animator Animator => _animator;

    public NavMeshAgent MeshAgent => _navMeshAgent;

    private void OnTriggerEnter(Collider other)
    {
        OnEnterEvent?.Invoke(this, other.gameObject);
    }
}
