using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject object;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        
    }

    // Update is called once per frame
    void Update()
    { 
        GameObject object = (transform.position.x = 10);
       
    }
}
