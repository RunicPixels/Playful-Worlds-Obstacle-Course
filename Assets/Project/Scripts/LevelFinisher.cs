using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinisher : MonoBehaviour {

    public GameObject particlesystem;
    public VoidAppear voidappear;
    public int level = 1;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collision detected with " + col);
        if (col.gameObject.tag == "Player")
        {
            particlesystem.GetComponent<ParticleSystem>().enableEmission = true;
            if(level == 1) voidappear.water = true;
            if (level == 2) voidappear.earth = true;
            if (level == 3) voidappear.air = true;
            if (level == 4) voidappear.fire = true;
        }
    }

}
