using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase de controlar el objeto jugador

public class PlayerControllerX : MonoBehaviour
{
    //Objeto que se genera
    public GameObject dogPrefab;
    //Bandera para saber si se puede generar un nuevo obejto dog
    private bool bBanderaPerro = true;
    private void Start()
    {

    }

    private void Update()
    {
        //Funcion para detener la actualizacion durante el tiempo indicado
        StartCoroutine(SpawnDog());
    }
    //Funcion que se encarga de generar un nuevo objeto perro
    private IEnumerator SpawnDog()
    {
    
        // Si se preciona espacio entra dentro de if
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SI el perro aun no ha sido generado entra
            if (bBanderaPerro)
            {
                //Se pone en falso para no generar un nuevo peero hasta que termine la espera
                bBanderaPerro = false;
                //Funcion que genera una instancia del objeto enviado por parametro, con la posicion y rotacion
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                //Espera de 2 segundos antes de seguir con el proceso
                yield return new WaitForSeconds(2f);
                //Bandera a verdadero para permitir generar un nuevo perro
                bBanderaPerro = true;
            }
        }
    }
}
