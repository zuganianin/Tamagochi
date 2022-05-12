using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField]
    private PersonParams playerParams;
    [SerializeField]
    private battler left;

    [SerializeField]
    private battler right;


    [SerializeField]
    private List<PersonParams> oponents;

    // Start is called before the first frame update
    void Start()
    {
        int day = PlayerPrefs.GetInt("day");
        left.InitalWithParams(playerParams);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
