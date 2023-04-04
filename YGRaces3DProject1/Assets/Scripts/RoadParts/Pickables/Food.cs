using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Pickable
{
    public override void Rotation(){
        transform.Translate(0, Mathf.Sin(Time.time*moveSpeed)*waveHeight, 0, Space.World);
        transform.Rotate(0, rotSpeed*Time.fixedDeltaTime, 0, Space.World);
    }
}
