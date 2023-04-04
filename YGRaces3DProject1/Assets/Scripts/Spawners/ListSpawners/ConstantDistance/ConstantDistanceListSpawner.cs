using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantDistanceListSpawner : ListSpawner
{
    [SerializeField] float distanceBetweenObjects = 2.8f;

    public override void OnStart(){
        distanceToSpawn = distanceBetweenObjects;
        SpawnStartObjects();
    }
}
