using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    int Ammo;
    void Start()
    {
        Ammo = 0;
    }
    

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

       
       

        if (other.gameObject.name == "AmmoBox")
        {
            other.gameObject.SetActive(false);
            Ammo += 20;
        }

    }

    



}