using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivaTrampa : MonoBehaviour
{
    public GameObject activarTrampa;
    public Rigidbody ObstaculoAereo;
    
    void OnTiggerEnter(Collider other)
    {
        Debug.Log("se estrello con" + other.gameObject.tag);
        if (other.gameObject.tag == "Carro")
        {
            Debug.Log("entre al activador");
            ObstaculoAereo.GetComponent<Rigidbody>().useGravity = true;
        }
    }

}