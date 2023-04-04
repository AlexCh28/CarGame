using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDistanceListSpawner : ListSpawner
{
    [SerializeField] float minDistance = 0f, maxDistance = 0f;

    public override void RandomizeDistance(){
        distanceToSpawn = Random.Range(minDistance, maxDistance);
    }
}
