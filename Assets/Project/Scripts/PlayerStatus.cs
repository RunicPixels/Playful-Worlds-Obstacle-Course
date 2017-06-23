using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

    public GameObject player;
    public Transform spawnpoint;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnControllerColliderHit(ControllerColliderHit col)
    {
        //Debug.Log("Collision detected with " + col);
        if(col.gameObject.tag == "Killzone")
        {
            player.transform.position = spawnpoint.position;
        }
        if (col.gameObject.tag == "Safezone")
        {
            spawnpoint = col.transform;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Collision detected with " + col);
        if (col.gameObject.tag == "Killzone")
        {
            player.transform.position = spawnpoint.position;
        }

    }
}
