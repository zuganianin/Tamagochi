using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressView : MonoBehaviour
{



    [SerializeField]
    private Image image;
    // Start is called before the first frame update

    public void setProgress(float procent)
    {
        image.fillAmount = procent;
    }
}
