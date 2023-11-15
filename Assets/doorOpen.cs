using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider other)
    {

        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("OpenDoor");
    }


    void OnTriggerExit(Collider other)
    {
        Debug.Log("door");
        GameObject parent = transform.parent.gameObject;
        Animation animation = parent.GetComponent<Animation>();
        animation.Play("Close");
    }






}
