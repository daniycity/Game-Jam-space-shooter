using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMinion1Script : MonoBehaviour
{
    public float initPosX;
    public float initPosY;

    public float movStep;

    public float checkpoint1X;
    public float checkpoint1Y;
    public float checkpoint1Time;
    public float checkpoint2X;
    public float checkpoint2Y;
    public float checkpoint2Time;
    public float checkpoint3X;
    public float checkpoint3Y;
    public float checkpoint3Time;

    public GameObject enemy;

    private TimerScript timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find ("Timer").GetComponent<TimerScript> ();
        /*enemy.transform.position.x = initPosX;
        enemy.transform.position.y = initPosY;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.time > checkpoint1Time && timer.time < checkpoint2Time){
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, 
                new Vector3(checkpoint1X, checkpoint1Y, enemy.transform.position.z), movStep);

        }else if(timer.time > checkpoint2Time && timer.time < checkpoint3Time){
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, 
                new Vector3(checkpoint2X, checkpoint2Y, enemy.transform.position.z), movStep);
        }else if(timer.time > checkpoint2Time && timer.time < 2000){
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, 
                new Vector3(checkpoint3X, checkpoint3Y, enemy.transform.position.z), movStep);
        }else if (timer.time >2000) timer.time = 0;
    }
}
