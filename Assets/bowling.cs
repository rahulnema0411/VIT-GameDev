using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowling : MonoBehaviour {
    
    public float speed = 20f;
    private float initialScale = 0.1f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        if(initialScale > 0.05f) {
            initialScale -= 0.001f;
        } else {
            initialScale += 0.001f;
        }

        
        Vector3 scale = new Vector3(initialScale,initialScale,transform.localScale.z);
        
        transform.localScale = scale;
        transform.Translate(0, speed*Time.deltaTime, 0);
    }

}
