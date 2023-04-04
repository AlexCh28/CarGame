using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSpawner : Spawner
{
    [SerializeField] protected List<GameObject> objects = new List<GameObject>();

    protected GameObject objectToSpawn;


    public override void SpawnOnePart(){
        GetObjectAndDistance();
        instance = Instantiate(objectToSpawn,transform.position,objectToSpawn.transform.rotation);
        ChangeInstanceTransformAfterSpawn();
    }


    private void Start() {
        GetObjectAndDistance();
        OnStart();
    }


    private void GetObjectAndDistance(){
        objectToSpawn = objects[Random.Range(0, objects.Count)];
        RandomizeDistance();
    }
}
