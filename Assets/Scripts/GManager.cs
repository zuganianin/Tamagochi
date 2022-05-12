using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

    [SerializeField]
    private ManWalk manWalk;


    [SerializeField]
    private InteractObject sleep, eat, work;


    private ParamAction currentAction;
    private InteractObject currentObject;

    private bool gameOver = false;
    private bool isBusy = false;

    public static GManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        manWalk.playerMoveEnded.AddListener(afterMove);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void InteractWithObject(InteractObject obj)
    //{

    //}

    public void makeParamAction(ParamAction act)
    {
        if(isBusy || gameOver)
        {
            return;
        }
        isBusy = true;
        currentAction = act;
        currentObject = getObjectForActionType(act.actionType);
        manWalk.MoveTo(currentObject.getinteractionPostion());

    }

    private void afterMove()
    {
        currentObject.animationEnded.AddListener(afterAnimation);
        currentObject.interactWithAction(currentAction);
    }

    private void afterAnimation()
    {
        currentObject.animationEnded.RemoveListener(afterAnimation);
        currentAction.MakeActions();
        chekGameOver();
        isBusy = false;
    }

    private void chekGameOver()
    {

    }

    private InteractObject getObjectForActionType(ActionType type)
    {
        switch (type)
        {
            case ActionType.Eat:
            {
                    return eat;
            }
            case ActionType.Sleep:
                {
                    return sleep;
                }
            case ActionType.Work:
                {
                    return work;
                }
        }
        return eat;
    }
}
