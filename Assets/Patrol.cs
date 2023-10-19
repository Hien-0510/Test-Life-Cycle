using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform departure,destination;
    public float speed, direction;

    private void Start  () => transform.position = departure.position;

    private void Update ()
    {
        if(transform.position == destination.position){
            direction = -1;
        }
        else if(transform.position == departure.position)
        {
            direction = 1;
        }
        if(direction == 1){
            transform.position = Vector3.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, departure.position, speed * Time.deltaTime);
        }   
    }
        
}
