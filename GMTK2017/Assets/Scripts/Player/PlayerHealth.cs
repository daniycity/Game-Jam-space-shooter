using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthScript
{

    public override void onUpdateInitialPhase(){
        
    }

    public override void onUpdateFinalPhase(){
        if(health<= 0) 
        {
           Destroy(character);
        }
    }

}
