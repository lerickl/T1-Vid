using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraScript : MonoBehaviour
{
    public GameObject personaje;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje != null)
        {
            _transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y, _transform.position.z/*, _transform.position.z*/);//Mover la camara en posicion x,y,z el jugador se mueva en x, en y y z no lo estoy haciendo quehaga nada
        }
    }
}
