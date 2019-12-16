using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ComputeNumbers : MonoBehaviour
{

    public TMP_Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_addNumbers;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_addNumbers.interactable = false;
        btn_reset.interactable = true;
    }

    public void Reset()
    {
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_addNumbers.interactable = true;
        btn_reset.interactable = false;
    }

    private int AddNumbers()
    {
        int tempResult = int.Parse(varA.text) + int.Parse(varB.text);
        return tempResult;
    }
}
