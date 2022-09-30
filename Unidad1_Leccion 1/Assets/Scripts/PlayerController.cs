using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    ///Author: Omar Arturo Moctezuma Padron
///Clase que controlla el GameObject player 
///Se encarga de actulizar la posicion vertical y horizontal de un objeto para dar movimiento a este al ser pulsada las Axis vertical u Horizontal.
 
public class PlayerController : MonoBehaviour
{

//Variable tipo float que almacena la velocidad Vertical a la que se desplazara el objeto
    public float fVelocidad;
//Variable tipo float que almacena la velocidad de rotacion Horizontal a la que se desplazara el objeto

    public float fRotacion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Se almacena 1 en caso de ser presionado alguno de los axxis verticales, caso contrario devuelve 0
       float fAvanza= Input.GetAxis("Vertical");
       //Almacena 1 en caso de ser presionado alguno de los axis horizontales, caso contrario devuelve 0
       float fGira=Input.GetAxis("Horizontal");
    //Se genera el desplazamiento vertical del objeto en caso de que fAvanza sea 1
        transform.Translate(Vector3.forward*Time.deltaTime*fVelocidad*fAvanza);
        //Se genera la rotacion en caso de que fGira sea 1
        transform.Rotate(Vector3.up,Time.deltaTime*fRotacion*fGira);
    }
}
