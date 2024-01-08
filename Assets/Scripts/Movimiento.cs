
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Movimiento : MonoBehaviour
{
    private Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();

    }

    void  Update () {
        float posx = Input.GetAxis("Horizontal");
        float posz = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(posx, 0, posz);
        rb.velocity = movement * 5f;
         
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisi�n detectada con: " + other.gameObject.name);

        // Verifica si el objeto con el que colision� es una moneda
        if (other.CompareTag("Esfera"))
        {
            // Destruye la moneda
            Destroy(other.gameObject);
        }
    }

}
