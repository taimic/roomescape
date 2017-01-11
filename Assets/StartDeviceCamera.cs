using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDeviceCamera : MonoBehaviour {

	public WebCamTexture webcamTexture = null;
	public bool isVisible = true;
	public GameObject stencil; 

	// Use this for initialization
	void Start () {
		webcamTexture = new WebCamTexture ();
		webcamTexture.requestedHeight = 1280;
		webcamTexture.requestedWidth = 720;
		GetComponent<Renderer>().material.mainTexture  = webcamTexture;
		webcamTexture.Play ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		if (GUI.Button (new Rect(100, 100, 200, 200), "press me!")) {
			if (isVisible){
				stencil.SetActive(false);
				isVisible=false;
			}
			else {
				stencil.SetActive(true);
				isVisible = true;
			}
		}	
		
	}
}
