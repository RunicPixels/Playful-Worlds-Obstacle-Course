using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowGround : MonoBehaviour
{
    ParticleSystem snow;
    // Use this for initialization
    void Start()
    {
        snow = gameObject.GetComponent(typeof(ParticleSystem)) as ParticleSystem;

    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other)
    {
        Rigidbody body = other.GetComponent<Rigidbody>();
        if (body)
        {
            Vector3 direction = other.transform.position - transform.position;
            direction = direction.normalized;
            body.AddForce(direction * 5);
        }
    }
}
