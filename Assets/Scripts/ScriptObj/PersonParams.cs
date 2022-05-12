using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "MyObject/PersonParams")]

[System.Serializable]
public class PersonParams : ScriptableObject
{
    [SerializeField]
    private string personName;

    [SerializeField]
    private Parametr str, agil, intel;

    public Parametr strP => str;
    public Parametr agilp => agil;
    public Parametr intelp => intel;

}
