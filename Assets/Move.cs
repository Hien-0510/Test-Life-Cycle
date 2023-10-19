using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    public float minX,maxX;

    private float direction = 1;

    void Update(){
        
        if(transform.position.x > maxX){
            direction = -1;
        }
        else if(transform.position.x < minX){
            direction = 1;
        }
        transform.Translate(direction * speed * Time.deltaTime,0,0);
    }
}
