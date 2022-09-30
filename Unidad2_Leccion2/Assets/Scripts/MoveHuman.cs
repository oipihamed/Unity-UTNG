using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de controlar los movimientos del jugador
public class MoveHuman : MonoBehaviour
{
    //Velocidad de movimiento del objeto jugador
    public float velocidad=5.0F;
    //Posicion maxima del objeto jugador 
    public float maximo=20;
    //Objeto proyectil que a generar
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si la posicion del objeto jugador es mayor que el maximo se mantien la poscion maxima
        if(transform.position.x>maximo){
            //Traslada el objeto a la poscion maxima
            transform.position=new Vector3(maximo,transform.position.y,transform.position.z);
        }
        //Si la posicion del objeto es menor a -maximo se mantiene la posicoin del objeto
        if(transform.position.x<-maximo){
            //Traslada el objeto a la posicion -maximo
            transform.position=new Vector3(-maximo,transform.position.y,transform.position.z);
        }
        //Obtiene la entrada de los axis horizontales izquierda derecha
        float flechas=Input.GetAxis("Horizontal");
        //Cambia la posicion del jugados al presion un axis horizontal
        transform.Translate(Vector3.right*Time.deltaTime*velocidad*flechas);
        //Al presionar el espacion entra en if
        if(Input.GetKeyDown(KeyCode.Space)){
            //Lanzar proyectil del jugador instanciado el objeto pizza
          Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }

    }
}
