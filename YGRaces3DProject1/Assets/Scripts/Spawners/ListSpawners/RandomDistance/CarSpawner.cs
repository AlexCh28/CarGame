using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : RandomDistanceListSpawner
{
    public override void OnStart(){
        instance = GameObject.FindObjectOfType<Car>().gameObject;
    }
}
