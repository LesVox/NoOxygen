using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour {

    public GameObject Planet;
    public GameObject Astronaut;

    private Vector3 Tilt;
    
	void Start () {
		
	}
	

	void Update () {
        Tilt = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);

        if(Astronaut.gameObject != null)
        {
            //Planet.transform.rotation = 
        }
            
	}
}
