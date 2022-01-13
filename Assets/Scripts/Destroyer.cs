using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Destroyable>())
            other.gameObject.GetComponent<Destroyable>().Destroy();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<Destroyable>())
            other.gameObject.GetComponent<Destroyable>().Destroy();
    }
}
