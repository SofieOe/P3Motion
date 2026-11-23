using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;

public class PointsRightorWrong : MonoBehaviour
{

    public Constraints constraintsScript;
    public HandTrigger left;
    public HandTrigger right;
    public GameObject Correct;
    public GameObject Wrong;
    public GameObject _pauseMenu;
    private bool _isGamePaused = false;
    public int WrongPoint =0;
    public int RightPoint =0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public IEnumerator WaitForSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        Correct.SetActive(false);
        Wrong.SetActive(false);
        //Debug.Log("inde i enumerator");
        //Debug.Log("her er delay " + delay);
    }




    // Update is called once per frame
    public void PointMath()
    {
        Debug.Log("PointMath START on " + name, this);
        Debug.Log($"DIAG | LeftTrue: {constraintsScript.LeftTrue} | RightTrue: {constraintsScript.RightTrue} | left.isTouched: {left.isTouched} | right.isTouched: {right.isTouched}");
        //RightPoint = Math.Clamp(0,0,100);
        //WrongPoint = Math.Clamp(0,0,100);

        Correct.SetActive(false);
        Wrong.SetActive(false);

        if(constraintsScript.RightTrue ==true && right.isTouched == true)
        {
            RightPoint ++;
            Debug.Log("right point ++");
            if (right.isTouched==true)
            {
                Correct.SetActive(true);
                StartCoroutine(WaitForSeconds(3f));
            }
        }
        else if(constraintsScript.LeftTrue ==true && left.isTouched == true)
        {
            RightPoint ++;
            Debug.Log("right point ++ else if ");
            if (left.isTouched==true)
            {
            Correct.SetActive(true);
            StartCoroutine(WaitForSeconds(3f));
            }
        }
        else if(right.isTouched == true || left.isTouched == true)
        {
            WrongPoint ++;
            Debug.Log("wrong point ++");
            if (left.isTouched==true || right.isTouched==true)
            {
            Wrong.SetActive(true);
            StartCoroutine(WaitForSeconds(3f));
            }
        }
    
        Debug.Log("her er point wrong "+ WrongPoint);
        Debug.Log("her er point right "+ RightPoint);
        
        
    }

        public void TogglePause()
        {
            if (!_isGamePaused)
            {
            _isGamePaused = true;
            _pauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
            }
            else
            {
                _isGamePaused = false;
                _pauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
            }
        }

}
