using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Variables")]
    [SerializeField] float movespeed= 5f ;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")* movespeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical")* movespeed* Time.deltaTime;
        transform.Translate(x,0,y);
    }
}
