using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthScript : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public GameObject character;
    public bool tookdamage;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        onUpdateInitialPhase();
        Debug.Log(health);
        onUpdateFinalPhase();
    }


    public void TakeDmg(float dmg)
    {
        health -= dmg;
    }

    public abstract void onUpdateInitialPhase();
    public abstract void onUpdateFinalPhase();
}
