using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceLevels : MonoBehaviour {
    public GameObject[] level;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < level.Length; i++)
        {
            level[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
