using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractObject : MonoBehaviour
{
    [SerializeField]
    private ProgressView progressView;

    [SerializeField]
    private Transform interactPostion;
    public UnityEvent animationStart= new UnityEvent();
    public UnityEvent animationEnded = new UnityEvent();

    private float inPorgressCounter = 0;
    private float inProgressMax = 0;
    private float curProgress = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        progressView.gameObject.SetActive(false);
        progressView.setProgress(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(inProgressMax != 0)
        {
            if (inPorgressCounter > inProgressMax) {
                animaEnded();
                return;
            }
            inPorgressCounter += Time.deltaTime;
            curProgress = inPorgressCounter / inProgressMax;
            progressView.setProgress(curProgress);
        }
    }

    public Vector3 getinteractionPostion()
    {
        return interactPostion.position;
    }

    public void interactWithAction(ParamAction action)
    {
        progressView.gameObject.SetActive(true);
        inProgressMax = action.timeExecute;
        inPorgressCounter = 0;
        curProgress = 0;
        animationStart.Invoke();
    }

    private void animaEnded() {
        progressView.gameObject.SetActive(false);
        inProgressMax = 0;
        animationEnded.Invoke();
    }

}
