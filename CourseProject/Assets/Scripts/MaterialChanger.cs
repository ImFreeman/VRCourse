using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Test()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _meshRenderer.material.SetColor("_Color", Color.red);
        }
    }
}
