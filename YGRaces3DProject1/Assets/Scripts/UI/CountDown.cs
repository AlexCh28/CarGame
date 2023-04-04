using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] GameObject numberFive, numberFour, numberThree, numberTwo, numberOne; 

    private void Start() {
        StartCoroutine("Countdown");
    }

    IEnumerator Countdown(){
        numberFive.SetActive(true);
        yield return new WaitForSeconds(1);
        numberFive.SetActive(false);
        numberFour.SetActive(true);
        yield return new WaitForSeconds(1);
        numberFour.SetActive(false);
        numberThree.SetActive(true);
        yield return new WaitForSeconds(1);
        numberThree.SetActive(false);
        numberTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        numberTwo.SetActive(false);
        numberOne.SetActive(true);
        yield return new WaitForSeconds(1);
        numberOne.SetActive(false);
    }
}
