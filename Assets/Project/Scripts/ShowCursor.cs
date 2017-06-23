using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour {
    public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(canvas.activeSelf == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
	}
}
