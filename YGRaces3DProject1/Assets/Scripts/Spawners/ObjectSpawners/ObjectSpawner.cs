using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : Spawner
{
    [SerializeField] GameObject prefab;
    [SerializeField] float distanceBetween=0;

    public override void SpawnOnePart(){
        instance = Instantiate(prefab,transform.position,transform.rotation);
    }

    private void Start() {
        distanceToSpawn = distanceBetween;
        OnStart();
    }
}
