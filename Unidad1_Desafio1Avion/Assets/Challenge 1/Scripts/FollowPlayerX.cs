using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de actualizar la posicion de la camara para seguir el GameObject player
public class FollowPlayerX : MonoBehaviour
{
    //Variable tipo GameObject que almace el objeto que seguira la camara 
    public GameObject plane;
    //Variable tipo Vector3 que almacena la Posicion inicial para la camara
    private Vector3 offset= new Vector3(30,0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Se actualiza la posicion de el objeto camara en relacion al GameObject  plane
        transform.position = plane.transform.position + offset;
    }
}
