using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class Car : MonoBehaviour
{
    public static event Action<int> OnScoreChange;

    // куб, в сторону которого машина будет поворачиваться и ехать
    [SerializeField] Transform cube;
    [SerializeField] Transform leftWheel, rightWheel;
    [SerializeField] float speed=5, lookLerpSpeed = 3, moveLerpSpeed = 3;

    [SerializeField] float cubeOffsetX = 1, cubeTransitionTime = 0.5f;

    int cubeLine = 0;

    bool canChangeLine = true;

    Vector3 LookPoint;
    Vector3 CarMovePoint;

    float score = 0;
    int oldScore = 0;
    int scoreModifier = 20;

    bool wantTurnLeft = false, wantTurnRight = false;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.D)) wantTurnRight = true;
        if (Input.GetKeyDown(KeyCode.A)) wantTurnLeft = true;
    }

    private void FixedUpdate() {
        // прерываем функцию если куб или колеса не были найдены
        if (cube==null) return;
        if (leftWheel==null || rightWheel==null) return;

        // движение куба
        if (canChangeLine){
            if (wantTurnRight){
                canChangeLine = false;
                wantTurnRight = false;
                cubeLine = (cubeLine+1)>1 ? 1 : (cubeLine+1);
                cube.DOMoveX(cubeOffsetX*cubeLine, cubeTransitionTime).OnComplete(()=>canChangeLine=true);
            }
            else if (wantTurnLeft){
                canChangeLine = false;
                wantTurnLeft = false;
                cubeLine = (cubeLine-1)<-1 ? -1 : (cubeLine-1);
                cube.DOMoveX(cubeOffsetX*cubeLine, cubeTransitionTime).OnComplete(()=>canChangeLine=true);
            }
        }
        
        // поворачиваем колеса
        LookPoint = new Vector3(cube.position.x, transform.position.y, cube.position.z);
        leftWheel.LookAt(LookPoint);
        rightWheel.LookAt(LookPoint);

        // создаем точку, на которую машина будет смотреть
        LookPoint = new Vector3(Mathf.Lerp(transform.position.x,cube.position.x,lookLerpSpeed*Time.fixedDeltaTime), transform.position.y, cube.position.z);
        transform.LookAt(LookPoint);

        // сдвигаем машину в сторону куба 
        CarMovePoint = new Vector3(cube.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, CarMovePoint, moveLerpSpeed*Time.fixedDeltaTime);

        // ведем подсчёт
        score += Time.fixedDeltaTime * scoreModifier;
        if ((int)score != oldScore){
            oldScore = (int)score;
            OnScoreChange?.Invoke(oldScore);
        }
    }
}
