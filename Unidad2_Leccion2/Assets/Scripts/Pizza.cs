using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de controlar los movimientos del proyectil pizza y animales
public class Pizza : MonoBehaviour
{
    //Velocidad a la que se desplazara el objeto
    public float velocidad=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Transforma la posicion del objeto de forma constante por la velocidad establecida
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad);
        
    }
}
