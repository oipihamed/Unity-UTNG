using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que se encarga de generar rotacion en el rotor del game object

public class SpinPropellerController : MonoBehaviour
{
    // Funcio llamada al iniciar la clase
    void Start()
    {   
    }

    // Metodo que se actuliza una vez por frame
    void Update()
    {
        //Rota el objeto mediante la funcion Euler generando la animacion del rotor
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
       
    }
}
