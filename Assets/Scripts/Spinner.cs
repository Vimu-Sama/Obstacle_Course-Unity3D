using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationalSpeed = 10f;
    void Update()
    {
        transform.Rotate(0f, rotationalSpeed * Time.deltaTime, 0f);
    }
}
