using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class Movement: MonoBehaviour {  
    public Transform[] target;  
    public float speed;  
    public int current;  
    // Use this for initialization    
    void Start() {}  
    // Update is called once per frame    
    void Update() {  
        if (transform.position != target[current].position) {  
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);  
            GetComponent < Rigidbody > ().MovePosition(pos);  
        } else if(current == 8){
	    Vector3 pos = Vector3.zero;
	} else current = (current + 1) % target.Length;  
	
    }  
}   