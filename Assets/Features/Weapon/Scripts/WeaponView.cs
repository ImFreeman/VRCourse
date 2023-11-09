using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable _grab;
    [SerializeField] private LineRenderer _renderer;
    [SerializeField] private float _lineLength;

    public event EventHandler<int> EnemyHitEvent;
    
    private void OnEnable()
    {
        _renderer.positionCount = 2;
        _grab.activated.AddListener(OnGunActivated);
    }

    private void OnGunActivated(ActivateEventArgs args)
    {
        Shot();
    }
    
    public void Shot()
    {
        RaycastHit hit;
        if (Physics.Raycast(_renderer.transform.position, _renderer.transform.forward, out hit, _lineLength))
        {
            var enemy = hit.transform.gameObject.GetComponent<EnemyView>();
            if (enemy != null)
            {
                EnemyHitEvent?.Invoke(this, enemy.gameObject.GetInstanceID());
                Debug.LogWarning($"Enemy hitted {enemy.gameObject.GetInstanceID()}");
            }
        }
    }

    private void Update()
    {
        var transform1 = _renderer.transform;
        _renderer.SetPositions(new []{transform1.position, transform1.forward * _lineLength});
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Shot();
        }
    }

    private void OnDisable()
    {
        _grab.activated.RemoveListener(OnGunActivated);
    }
}
