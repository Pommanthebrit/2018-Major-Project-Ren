using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour {
    public GameObject Camera;
    public GameObject Ren;
    public GameObject Nabella;
    public GameObject Midpoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Midpoint.transform.position = (Ren.transform.position + Nabella.transform.position) / 2;
        Camera.transform.LookAt(Midpoint.transform) ;
    }
}
