using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayButton : MonoBehaviour {

	public bool isVisible = true;
	public GameObject stencil; 
	public float slider = 1.0f;

	// Use this for initialization
	void Start () {
	}

	void OnGUI() {
		slider = GUI.HorizontalSlider(new Rect(50,50,250,80), slider, 0.0f, 1.0f);
		stencil.GetComponent<Renderer>().material.color = new Color(1,1,1, slider);

		if (GUI.Button (new Rect(50, 150, 150, 100), "display stencil")) {
			if (isVisible){
				stencil.GetComponent<MeshRenderer> ().enabled = false;
				stencil.SetActive(false);
				isVisible=false;
			}
			else {
				stencil.GetComponent<MeshRenderer> ().enabled = true;
				stencil.SetActive(true);
				isVisible = true;
			}
		}	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
