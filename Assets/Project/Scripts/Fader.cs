using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour {
    public Renderer meshRenderer;
    public BoxCollider collider;
    public float fadeSpeedOut = 0.01f;
    public float fadeSpeedIn = 0.01f;
    public int fadeBackDelay = 300;
    private int fadeTimer = 0;
    private Color thisColor;
    private Color col = new Color();
    public int state = 0;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        switch (state)
        {
            case 0: // Idle
                break;
            case 1: // Fading Out
                FadeOut();
                break;
            case 2: // Waiting for Fade In
                Count();
                break;
            case 3: // Fading In;
                FadeIn();
                break;
            default:
                break;
        }
        
        

	}
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collision detected between " + this+ " and " + col);
        if (col.gameObject.tag == "Player")
        {
            state = 1;
        }
    }
    void FadeOut()
    {
        Color color = meshRenderer.material.color;
        color.a -= fadeSpeedOut;
        meshRenderer.material.color = color;
        if (color.a <= 0f)
        {
            state = 2;
            collider.enabled = false;
            fadeTimer = 0;
        }
    }
    void Count()
    {
        fadeTimer++;
        if(fadeTimer >= fadeBackDelay)
        {
            collider.enabled = true;
            state = 3;
        }
    }

    void FadeIn()
    {
        Color color = meshRenderer.material.color;
        color.a += fadeSpeedIn;
        meshRenderer.material.color = color;
        if (color.a >= 1f)
        {
            state = 0;
        }
    }
}
