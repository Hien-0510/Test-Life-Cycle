using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

        public float anglePerSecond;

    void Update() => transform.Rotate(0,0, anglePerSecond *Time.deltaTime);
}
