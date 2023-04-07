using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectToSpawn))]
[RequireComponent(typeof(AwakeSpawn))]
public class UpdateSpawn : MonoBehaviour
{
    private ObjectToSpawn _objectToSpawn;
    private AwakeSpawn _awakeSpawn;

    private GameObject _itemInstance;
    private float _distanceBetween;

    private void Awake() {
        _objectToSpawn = GetComponent<ObjectToSpawn>();    
        _awakeSpawn = GetComponent<AwakeSpawn>();    
    }

    private void Start() {
        _itemInstance = _awakeSpawn.ItemInstance ? 
        _awakeSpawn.ItemInstance : 
        Instantiate(_objectToSpawn.Objects[Random.Range((int)0,(int)_objectToSpawn.Objects.Count)], transform.position, transform.rotation);
        
        _distanceBetween = _awakeSpawn.DistanceBetween;
    }

    private void Update() {
        if (Vector3.Distance( _itemInstance.transform.position, transform.position) >= _distanceBetween )
            _itemInstance = Instantiate(_objectToSpawn.Objects[Random.Range((int)0,(int)_objectToSpawn.Objects.Count)], transform.position, transform.rotation);
    }
}
