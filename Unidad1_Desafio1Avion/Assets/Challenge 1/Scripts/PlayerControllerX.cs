using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de generar el movieminto en el GameObject de player.


public class PlayerControllerX : MonoBehaviour
{
    //Variable tipo float que almacena la velocidad Vertical que avanzara el GameObject
    public float speed;
     //Variable tipo float que almacena la velocidad Horizontal que rotara el GameObject
    public float rotationSpeed;
    //Variable tipo float que almacena el valor del axis Vertical
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtiene la entrada vertical del usuario 
        verticalInput = Input.GetAxis("Vertical");

        // Mueve el game object de forma constante en forma
        transform.Translate(Vector3.forward * Time.deltaTime* speed);

        //Eleva o inclina el GameObject en relacion a la entrada vertical del usuario
        transform.Rotate(Vector3.left *rotationSpeed*Time.deltaTime*verticalInput);
    }
}
