using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Animation _animation;
    [SerializeField] private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator.runtimeAnimatorController.animationClips[0].events[0].functionName = "Test2";
    }

    private void Test()
    {
        Debug.Log("Animation!");
    }

    private void Test2()
    {
        Debug.Log("Test!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(_speed * 1.0f, 0.0f, 0.0f));
        }
        
    }
}
