using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : RoadPart
{
    [SerializeField] protected float rotSpeed, moveSpeed, waveHeight;

    [SerializeField] GameObject PickUpBurst;

    GameObject VFXInstance;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Car"){
            VFXInstance = Instantiate(PickUpBurst, other.transform.position, other.transform.rotation);
            VFXInstance.transform.parent = other.transform;
            Destroy(VFXInstance, 2);
            Destroy(gameObject);
        }
    }
}
