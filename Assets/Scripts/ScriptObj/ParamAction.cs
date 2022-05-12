using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionType
{
    Eat,
    Sleep,
    Work
}


[CreateAssetMenu(menuName = "MyObject/ParamAction")]

[System.Serializable]
public class ParamAction : ScriptableObject
{
    [SerializeField]
    private string actName;

    [SerializeField]
    private List<ParAction> parametrs;

    [SerializeField]
    private ActionType _actionType;

    public ActionType actionType => _actionType;


    [SerializeField]
    private float _timeExecute;
    public float timeExecute => _timeExecute;

    public void MakeActions()
    {
        foreach (ParAction par in parametrs)
        {
            par.MakeAction();
        }
    }
}
