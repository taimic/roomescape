using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnable : MonoBehaviour {

    public AudioSource source;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    source.Play();
                }
            }
        }
	}

    private void OnEnable()
    {
        //source.Play();
    }

    private void OnDisable()
    {
        source.Stop();
    }
}
