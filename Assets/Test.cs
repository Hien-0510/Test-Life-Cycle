using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void FixedUpdate(){
        print($"<color=green>Fixed Update at frame {Time.frameCount}</color>");
    }

    private void Update(){ 
        print($"Update at frame {Time.frameCount}");
    }

    private void LateUpdate(){
        print($"Late at frame {Time.frameCount}");
    }

    private void OnDestroy(){
        print("Destroyed");
    }

    private void OnDisable(){
        print($"OnDisable at frame {Time.frameCount}");
    }
}
