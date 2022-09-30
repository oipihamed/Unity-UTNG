using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de detectar la colision entre dos objetos
public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Funcion que se dispara al detectar una colision se envia como parametro el Collider
    private void OnTriggerEnter(Collider other){
        //Funcion que destruye el objeto
        Destroy(gameObject);
        //Funcion para destruir el objeto con el cual se ha colisonado
        Destroy(other.gameObject);
    }
}
