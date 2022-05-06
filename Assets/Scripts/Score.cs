using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;
    bool tempCond = true;
    private void Awake()
    {
        score = 0;
        tempCond = true;
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if(collision.gameObject.tag=="Obstacle" && tempCond)
        {
            MeshRenderer meshRenderer = collision.gameObject.GetComponent<MeshRenderer>();
            ObjectHit hitScript = collision.gameObject.GetComponent<ObjectHit>();
            if (meshRenderer.material.color != Color.yellow)
            {
                meshRenderer.material.color = Color.yellow;
                hitScript.ChangeBool(true);
                tempCond = hitScript.GetBool();
                hitScript.ChangedColor();
                score++;
                Debug.Log("Number of times you have hit the obstacles: " + score);
            }
            
        }
    }
}
