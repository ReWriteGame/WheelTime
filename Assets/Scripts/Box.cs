using System;
using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
    public UnityEvent OnTouchEvent;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<Bullet>())
            OnTouchEvent?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Bullet>())
            OnTouchEvent?.Invoke();
    }
}
