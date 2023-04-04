using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    protected static GameObject roadSpawner;
    protected GameObject instance;
    protected float distanceToSpawn = 2.8f;

    private int amountOfSegments = 50;


    public virtual void OnStart(){}
    public virtual void SpawnOnePart(){}
    public virtual void RandomizeDistance(){}
    public virtual void ChangeInstanceTransformAfterSpawn(){}


    protected void SpawnStartObjects(){
        for (int i = 0; i<amountOfSegments; i++){
            if (transform.position.z<=roadSpawner.transform.position.z) {
                SpawnOnePart();
                if (i!=amountOfSegments-1) transform.Translate(0,0,distanceToSpawn, Space.World);
            }
        }
    }


    private void FixedUpdate() {
        if (Vector3.Distance(instance.transform.position, transform.position)>=distanceToSpawn) SpawnOnePart();
    }
}
