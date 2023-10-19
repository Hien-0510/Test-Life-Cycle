using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    public SpriteRenderer _renderer;
    private float startTime;
    public float interval;

    // void Update(){
    //     if(Time.time - startTime >= interval){
    //         _renderer.enabled = !_renderer.enabled;
    //         startTime = Time.time; 
    //     }
    // }

    private void Start()
        => InvokeRepeating(nameof(TogglenInvisible), interval, interval);

        private void TogglenInvisible()
            => gameObject.SetActive(!gameObject.activeSelf);
}
