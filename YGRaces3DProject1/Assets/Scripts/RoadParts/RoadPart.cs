using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPart : MonoBehaviour
{
    public enum Direction{ 
        up,
        down,
        left,
        right,
        forward,
        back
    }

    [SerializeField] protected Direction direction  = Direction.back;
    protected Vector3 directionVector;

    protected float speed = 5;

    private void Start() {
        OnStart();
        if (direction == Direction.up) directionVector = Vector3.up;
        else if (direction == Direction.down) directionVector = Vector3.down;
        else if (direction == Direction.left) directionVector = Vector3.left;
        else if (direction == Direction.right) directionVector = Vector3.right;
        else if (direction == Direction.forward) directionVector = Vector3.forward;
        else if (direction == Direction.back) directionVector = Vector3.back;
    }

    private void FixedUpdate() {
        Move();
        Rotation();
    }

    public virtual void OnStart(){}
    public virtual void Move(){
        transform.Translate(directionVector*speed*Time.fixedDeltaTime, Space.World);
    }
    public virtual void Rotation(){}
}
