using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;

    [SerializeField]
    private Transform target;
    public float damage;
    public float hitWaitTime = 1f; //attack cooldown
    private float hitCounter;


    void Start()
    {
        target = FindObjectOfType<PlayerPhonq>().transform;
    }


    void Update()
    {
        theRB.velocity = (target.position - transform.position).normalized * moveSpeed;
        if(hitCounter > 0f)
        {
            hitCounter -= Time.deltaTime;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null && collision.gameObject.tag == "Player" && hitCounter <= 0f) {
            PlayerHealthController.instance.TakeDamage(damage);
            hitCounter = hitWaitTime;
        }
    }
}
