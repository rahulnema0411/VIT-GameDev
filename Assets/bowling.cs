using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowling : MonoBehaviour {
    
    public float speed = 20f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        transform.Translate(0, speed*Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("bat")) {
            Debug.Log("hit ball");
        }
    }

}
