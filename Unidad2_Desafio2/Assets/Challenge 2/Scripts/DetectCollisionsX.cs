using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de destruir los objetos al detectar una colision

public class DetectCollisionsX : MonoBehaviour
{
//Funcion que se dispara al detectar una colision
//Se envia como parametro el collider
    private void OnTriggerEnter(Collider other)
    {
        //Funcion que destruye el objeto enviado por parametro
        Destroy(gameObject);
    }
}
