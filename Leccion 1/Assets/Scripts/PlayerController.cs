using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fVelocidad;
    public float fRotacion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       float fAvanza= Input.GetAxis("Vertical");
       float fGira=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*fVelocidad*fAvanza);
        transform.Rotate(Vector3.up,Time.deltaTime*fRotacion*fGira);
    }
}
