using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSpawner : ConstantDistanceListSpawner
{
    [SerializeField] bool isRightSide = false;

    public override void ChangeInstanceTransformAfterSpawn(){
        if (!isRightSide) return;

        instance.transform.Rotate(0,180,0);
    }
}
