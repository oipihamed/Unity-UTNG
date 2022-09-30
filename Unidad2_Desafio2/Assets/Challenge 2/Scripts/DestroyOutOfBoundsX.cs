using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de destruir los objetos dependiendo de su posicion en pantalla
public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Almacena el limite izuierdo para destruir un objeto
    private float leftLimit = -35;
    //Almace el limite inferior para destruir un objeto
    private float bottomLimit = 0;

    // Update is called once per frame
    void Update()
    {
        // Destruye dogs si la posicion en x es menor al limite 
        if (transform.position.x < leftLimit)
        {
            //Funcion que destruye el objeto que se pasa por parametro
            Destroy(gameObject);
        } 
        // Destruye balls si la posicion en y es menor al limite
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
