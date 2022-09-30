using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Omar Arturo Moctezuma Padron
//Clase que controla la generacion aleatoria de un arreglo de objetos
public class SpawnManagerX : MonoBehaviour
{
    //Arreglo de objetos a generar
    public GameObject[] ballPrefabs;
    //Limite izquiero de spawn para objetos 
    private float spawnLimitXLeft = -22;
    //Limite derecho de spawn para objetos 
    private float spawnLimitXRight = 7;
    //Posicion de spawn de objetos
    private float spawnPosY = 30;
    //Deleay para inico de funcion de spawn
    private float startDelay = 1.0f;
    //Intervalo de tiempo de espera para repeticion de funcion de spawn
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        //Se genera un intervalo aleatorio de repeticion entre 3 y 5 
        spawnInterval = Random.Range(3f,5f);
        //Funcion que se encarga de repetir la funcion enviada por parametro de forma constante tomando encuenta el retraso de inicio y el intervalo de repeticion
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
private void Update() {
   
}
    // Genera un objeto ball aleatorio del arreglo de objetos en una posicion X aleatorio constantemente
    void SpawnRandomBall ()
    {
        //Valor del objeto a generar de forma aleatorio tomando en cuenta el tamaño del arreglo de objetos
        int ballIndex=Random.Range(0,ballPrefabs.Length);

        // Genra la posicion aleatoria en que se generara el objeto ball
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instancia un objeto bola del arreglo de objetos en la posicion aletorio spawnPos
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
