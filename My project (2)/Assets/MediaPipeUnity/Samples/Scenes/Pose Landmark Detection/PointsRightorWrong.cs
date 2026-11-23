using System;
using UnityEngine;

public class PointsRightorWrong : MonoBehaviour
{

    public Constraints constraintsScript;
    public HandTrigger left;
    public HandTrigger right;
    public int WrongPoint =0;
    public int RightPoint =0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    public void PointMath()
    {
        Debug.Log("PointMath START on " + name, this);
        Debug.Log($"DIAG | LeftTrue: {constraintsScript.LeftTrue} | RightTrue: {constraintsScript.RightTrue} | left.isTouched: {left.isTouched} | right.isTouched: {right.isTouched}");
        //RightPoint = Math.Clamp(0,0,100);
        //WrongPoint = Math.Clamp(0,0,100);

        if(constraintsScript.RightTrue ==true && right.isTouched == true)
        {
            RightPoint ++;
            Debug.Log("right point ++");
        }
        else if(constraintsScript.LeftTrue ==true && left.isTouched == true)
        {
            RightPoint ++;
            Debug.Log("right point ++ else if ");
        }
        else if(right.isTouched == true || left.isTouched == true)
        {
            WrongPoint ++;
            Debug.Log("wrong point ++");
        }
    
        Debug.Log("her er point wrong "+ WrongPoint);
        Debug.Log("her er point right "+ RightPoint);

        /*switch (constraintsScript.LeftTrue)
        {
            
            case true:
                RightPoint ++;
                Debug.Log("right!!!");
                
            break;

            case false:


            default:
                WrongPoint++;
                Debug.Log("wrong!!!");
                break;
           
        
            
            
        }
        switch (constraintsScript.RightTrue)
        {
            case true:
                RightPoint ++;
                Debug.Log("TRUE");
                
            break;

            case false:

            default:
            WrongPoint++;
            Debug.Log("FALSE");
            break;

            
        }

        Debug.Log("her er point wrong "+ WrongPoint);
        Debug.Log("her er point right "+ RightPoint);*/
        
    }
    



}
