using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///Author: Omar Arturo Moctezuma Padron
///Clase que controlla el Objeto MainCamera
///Establece la posicion de la camara en el juego y actuliza dicha posicion dependiendo de la posicion de objeto de jugado

public class CameraController : MonoBehaviour
{
    #region Atributos
    //tanque: Atributo tipo GameObject que almacena un la ref a un Game object.
    
    public GameObject tanque;
    //pos: Atributo tipo Vector3 que sirve para asignar una posicion fija al objeto mainCamera
    private Vector3 pos=new Vector3(0,10,-14);
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cambia la posicion del objeto mainCamera usando la posicion de el objeto tanque.
        transform.position=tanque.transform.position+pos;
      
    }
}
