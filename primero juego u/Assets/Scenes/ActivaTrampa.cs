using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaTrampa : MonoBehaviour {
    public GameObject ActivarTrampa;
    public Rigidbody esfera;
    // Start is called before the first frame update
    void OnTiggerEnter (Collider other) {
        Debug.Log("se estrello con" + other.gameObject.tag); 
        if (other.gameObject.tag == "Carro")
        {
            Debug.Log("entre al activador");
            esfera.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
