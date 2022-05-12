using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ParAction
{
    [SerializeField]
    private Parametr parametr;

    [SerializeField]
    private float delta;

    public void MakeAction()
    {
        parametr.changeVal(delta);
        
    }
}
