using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float mov_Speed;
    public float movement_Smoothing;
    private Vector3 m_Velocity = Vector3.zero;
    public GameObject bullet;
    public Transform firepoint;
    private float rateOfFirePointer = 0.01f;
    public float shootingTime = 0.3f; //decrease for more bullet in less time

    void FixedUpdate()
    {
        float horizontal_Key =  Input.GetAxisRaw("Horizontal");    // catch input from unity axis system
        float vertical_Key =  Input.GetAxisRaw("Vertical");        // 
        
        float horizontal_Mvmt = horizontal_Key*mov_Speed*Time.fixedDeltaTime; // moltiply it for the specified speed 
        float vertical_Mvmt = vertical_Key*mov_Speed*Time.fixedDeltaTime;     // fixedDeltaTime made the movement more smoother
       
        Vector3 Hor_targetVelocity = new Vector2(horizontal_Mvmt * 10f, vertical_Mvmt*10f);   // the vector who represent the x and y velocity
       
        Rb.velocity = Vector3.SmoothDamp(Rb.velocity, Hor_targetVelocity, ref m_Velocity, movement_Smoothing);  // apply the speep vector to the player's rigidbody
    }
    void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > rateOfFirePointer){
            rateOfFirePointer = Time.time + shootingTime;
            Instantiate(bullet, firepoint.position,firepoint.rotation);   // it shoot 
        } 

    }
}
