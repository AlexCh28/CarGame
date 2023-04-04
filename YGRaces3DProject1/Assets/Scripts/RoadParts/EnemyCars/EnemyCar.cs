using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : RoadPart
{
    [SerializeField] protected float carSpeed = 0;


    public override void OnStart(){
        speed = carSpeed;
    }


    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Car")){
            // endgame
        }
    }
}
