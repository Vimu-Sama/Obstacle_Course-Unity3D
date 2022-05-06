using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color color;
    bool ischanged = false;
    private void Awake()
    {
        ischanged = false;
        color = GetComponent<MeshRenderer>().material.color;
    }

    public void ChangedColor()
    {
        if(ischanged)
        {
            StartCoroutine(ChangeColorToOriginal());
        }
    }

    IEnumerator ChangeColorToOriginal()
    {
        yield return new WaitForSeconds(4);
        GetComponent<MeshRenderer>().material.color = color;
        ischanged = false;
    }
    public void ChangeBool(bool colorChanged)
    {
        ischanged = colorChanged;
    }

    public bool GetBool()
    {
        return ischanged;
    }
   
}
