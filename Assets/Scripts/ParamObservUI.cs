using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParamObservUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (data != null)
        {
            updateWithEpisodeData(data);
            data.valueCnaged.AddListener(updateData);
        }
    }

    [SerializeField]
    private Parametr data;

    [SerializeField]
    private Text title, value;

    
    public virtual void updateWithEpisodeData(Parametr episodeData)
    {
        title.text = episodeData.parName;
        value.text = episodeData.curentValue.ToString();
    }

    private void updateData() {
        if (data != null)
        {
            Debug.Log("update");
            updateWithEpisodeData(data);
        }
        }


    public void Awake()
    {
        
    }
}
