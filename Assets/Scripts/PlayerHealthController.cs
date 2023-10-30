using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    public float currentHealth, maxHealth;
    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage) { }
}
