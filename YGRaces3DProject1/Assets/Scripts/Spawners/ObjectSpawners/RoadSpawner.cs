using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : Spawner
{
    [SerializeField] List<GameObject> roadParts = new List<GameObject>();

    GameObject partToSpawn;

    public override void SpawnOnePart(){
        instance = Instantiate(partToSpawn,transform.position,transform.rotation);
    }

    private void Awake() {
        roadSpawner = this.gameObject;
        partToSpawn = roadParts[0];
        SpawnStartObjects();
    }   
}
