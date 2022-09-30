using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de dar movimiento a un objeto

public class MoveForwardX : MonoBehaviour
{
    //Velocidad a la que se movera el objeto
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Cambia la posicion del objeto de forma constante en relacion a la velocidad 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
