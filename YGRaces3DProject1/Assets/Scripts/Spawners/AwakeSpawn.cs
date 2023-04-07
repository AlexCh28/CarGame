using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectToSpawn))]
public class AwakeSpawn : MonoBehaviour
{
    [SerializeField]
    private int _amountOfStartObjects = 0;
    [SerializeField]
    private float _distanceBetween = 1;

    private GameObject _itemInstance;
    private ObjectToSpawn _objectToSpawn;

    public GameObject ItemInstance => _itemInstance;
    public float DistanceBetween => _distanceBetween;

    private void Awake() {
        _objectToSpawn = GetComponent<ObjectToSpawn>(); 

        for (int i = 0; i<_amountOfStartObjects; i++){
            _itemInstance = Instantiate(_objectToSpawn.Objects[Random.Range((int)0,(int)_objectToSpawn.Objects.Count)], transform.position, transform.rotation);
            transform.Translate(0, 0, _distanceBetween, Space.World);
        }
    }
}
