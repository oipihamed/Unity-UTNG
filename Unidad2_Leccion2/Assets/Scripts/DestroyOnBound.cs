using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de destruir un objeto
public class DestroyOnBound : MonoBehaviour
{
    //Posicion superior de referencia para destruir objeto
    public float topBound=30;
    //Posicion inferior de referencia para destruir objeto
    public float lowerBound=-10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si la posicion del objeto en z es mayor a la posicion superior se destruye el objeto
        if(transform.position.z>topBound){
            Destroy(gameObject);
            
        }else if(transform.position.z<lowerBound){//Si la posicion del objeto en z es menor a la posicion inferior se destruye el objeto
            //Se envia mensaje a log 
            Debug.Log("Game Over!");
            //Funcion que destruye el objeto enviado por parametro
            Destroy(gameObject);
        }
    }
}
