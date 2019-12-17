using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ComputeNumbers : MonoBehaviour
{

    public Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_addNumbers;

    public void SetResult()
    {
        Debug.Log("SubNumbers pressed");
        result.text = SubNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_addNumbers.interactable = false;
        btn_reset.interactable = true;
        
    }

    public void ResetGui()
    {
        varA.text = "0";
        varB.text = "0";
        result.text = "Result";
        varA.interactable = true;
        varB.interactable = true;
        btn_addNumbers.interactable = true;
        btn_reset.interactable = false;
    }

    private int SubNumbers()
    {
        
        int tempResult = int.Parse(varA.text) - int.Parse(varB.text);
        return tempResult;
        
    }
    
}
