using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3;
    bool checkCond = true;
    MeshRenderer renderer;
    Rigidbody rb;

    private void Start()
    {
        renderer= GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rb= GetComponent<Rigidbody>();
        rb.useGravity = false;

    }
    void Update()
    {
        if(Time.time>=waitTime && checkCond)
        {
            renderer.enabled = true;
            rb.useGravity= true;
            checkCond = false;
        }
    }
}
