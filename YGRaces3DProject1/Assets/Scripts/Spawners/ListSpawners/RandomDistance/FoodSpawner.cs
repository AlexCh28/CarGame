using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : RandomDistanceListSpawner
{
    public override void OnStart(){
        SpawnStartObjects();
    }
}
