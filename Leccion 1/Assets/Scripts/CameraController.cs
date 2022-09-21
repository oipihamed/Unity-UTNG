using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject tanque;
    private Vector3 pos=new Vector3(0,10,-14);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=tanque.transform.position+pos;
      
    }
}
