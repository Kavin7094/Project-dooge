using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droper : MonoBehaviour
{
    [SerializeField] float TimeToDrop =5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        renderer =  GetComponent<MeshRenderer>();

        renderer.enabled=false;
        rigidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeToDrop)
        {
            renderer.enabled=true;
            rigidbody.useGravity=true;
        }
    }
}
