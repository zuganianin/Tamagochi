using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "MyObject/Parametr")]

[System.Serializable]
public class Parametr : ScriptableObject
{
    public string parName;
    public float curentValue;
    public float maxVal;
    public float startVal;

    public UnityEvent valueCnaged = new UnityEvent();

    public void changeVal(float delta)
    {
        curentValue += delta;
        if (curentValue > maxVal)
        {
            curentValue = maxVal;
        }
        valueCnaged.Invoke();
    }
}
