using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField]float anglex=0;
    [SerializeField]float angley=0;
    [SerializeField]float anglez=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(anglex,angley,anglez);
    }
}
