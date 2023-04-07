using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToSpawn : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _objects = new List<GameObject>();

    public List<GameObject> Objects => _objects;
}
