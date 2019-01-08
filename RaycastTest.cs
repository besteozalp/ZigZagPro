using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            hitInfo.transform.name = "x";
            Debug.Log("asagida " + hitInfo.transform.name + " var");
        }

		
	}
}
