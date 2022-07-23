using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        this.time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.time++;
    }
}
