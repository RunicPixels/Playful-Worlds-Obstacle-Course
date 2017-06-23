using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDistanceEnabler : MonoBehaviour {

    public GameObject player;
    public GameObject particlesystem;

    public bool trailX = false;

    public int distance = 100;
   


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float distancePP = Vector3.Distance(player.transform.position, particlesystem.transform.position);
        if (distancePP < distance)
        {
            //Debug.Log("Distance: " + distancePP + " player: " + player + "particleSystem: " + particlesystem);
            particlesystem.GetComponent<ParticleSystem>().enableEmission = true;
        }
        else particlesystem.GetComponent<ParticleSystem>().enableEmission = false;
        if (trailX)
        {
            Vector3 pos = particlesystem.transform.position;
            pos.x = player.transform.position.x;
            particlesystem.transform.position = pos;
        }
    }
}
