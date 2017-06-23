using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidAppear : MonoBehaviour {
    public GameObject[] voidObjects;
    public bool water = false, earth = false, air = false, fire = false;
    private bool theVoid = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(water && earth && air && fire && !theVoid)
        {
            for(int i = 0; i<voidObjects.Length; i++)
            {
                voidObjects[i].SetActive(true);
            }
            theVoid = true;
        }
	}
}
