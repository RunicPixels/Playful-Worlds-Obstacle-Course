using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterCoolDown : MonoBehaviour {
    public int cooldownAmount;
    public int cooldownTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldownTimer > 0)
        {
            cooldownTimer--;
        
        }
        //Debug.Log("CooldownTimer Teleporter: " + cooldownTimer);
    }
}
