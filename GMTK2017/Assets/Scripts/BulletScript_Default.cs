using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript_Default : MonoBehaviour
{
    
    public Rigidbody2D bulletBody;
    public float bulletSpeed;
    private Vector3 mVelocity = Vector3.zero;
    public float bulletDmg = 10;

    void Start(){

    }

    
    void Update()
    {
        Vector3 bulletVelocity = new Vector2 (0f, bulletSpeed*Time.fixedDeltaTime*10f);
        bulletBody.velocity = bulletVelocity;
    }

    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if(hitinfo.transform.tag == "Scenario")
        {
            Destroy(gameObject);
        }
        if(hitinfo.transform.tag == "Enemy")
        {
            EnemyHealth enemy = hitinfo.GetComponent<EnemyHealth>();
            enemy.TakeDmg(bulletDmg);
            Destroy(gameObject);
        }
    }
   
}

