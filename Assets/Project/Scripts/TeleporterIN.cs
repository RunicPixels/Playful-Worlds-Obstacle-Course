using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterIN : MonoBehaviour {

    public Transform destination;
    public TeleporterCoolDown tc;
    public GameObject OutObject;
    public GameObject InObject;
    public Material skybox;
    public AudioSource playerAudioSource;
    public AudioClip teleport;
    private int cd;
	// Use this for initialization
	void Start () {
        cd = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider col)
    {
        if (tc != null) { cd = tc.cooldownTimer; }
        Debug.Log("Collision detected with " + col);
        if (col.gameObject.tag == "Player" && cd == 0)
        {
            col.transform.position = destination.position;
            if(skybox != null)RenderSettings.skybox = skybox;
            if (OutObject != null) OutObject.SetActive(false);
            if (InObject != null) InObject.SetActive(true);
            if (tc != null) tc.cooldownTimer = tc.cooldownAmount;
            playerAudioSource.PlayOneShot(teleport);
        }
    }
}
