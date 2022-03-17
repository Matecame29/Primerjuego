using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoAereo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag== "Carro")
        {
            Debug.Log("Game Over");
            Application.LoadLevel("escena 1");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
