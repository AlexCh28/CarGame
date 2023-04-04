using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTrail : MonoBehaviour
{
    [SerializeField] GameObject DustVFX, SpawnPoint;

    [SerializeField] float spawnInterval = 0.1f;

    GameObject VFXInstance;
    float timer = 0;

    private void Start() {
        timer = 0;
    }

    private void Update() {
        timer += Time.deltaTime;
        if (timer >= spawnInterval){
            VFXInstance = Instantiate(DustVFX, SpawnPoint.transform.position, DustVFX.transform.rotation);
            timer = 0;
        }
    }
}
