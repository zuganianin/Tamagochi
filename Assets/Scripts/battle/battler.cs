using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battler : MonoBehaviour
{

    [SerializeField]
    private battler oponent;

    [SerializeField]
    private float delay = 0;

    private float streight, agila, intellect;


    private float streight_mod, agila_mod, intellect_mod;


    public void InitalWithParams(PersonParams person)
    {
        InitializeWith(person.strP.curentValue, person.agilp.curentValue, person.intelp.curentValue);
    }

    public void InitializeWith(float streight, float agila, float intellect)
    {
        this.streight = streight;
        this.agila = agila;
        this.intellect = intellect;

        streight_mod = clacModifer(streight);
        agila_mod = clacModifer(agila);
        intellect_mod = clacModifer(intellect);
    }

    private float clacModifer(float param)
    {
       float modif = param - 10.0f;
        if (modif <= 0)
        {
            modif = 0;
        }
        else
        {
            modif = (int)(modif / 2);
        }
        return modif;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    public void calcAtack()
    {
        float atackLevel = Random.Range(1, 4) + agila_mod + intellect_mod;
        float atackStr = Random.Range(1, 4) + streight_mod;

        oponent.takeDamage(atackStr, atackLevel);
    }

    public void takeDamage(float damage, float atackLevel)
    {
        //1d20
        float missLevel = Random.Range(1, 4) + agila_mod + intellect_mod;
    }

}
