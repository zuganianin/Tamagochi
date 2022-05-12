using System.Collections;
using System.Collections.Generic;
using PolyNav;
using UnityEngine;
using UnityEngine.Events;

public class ManWalk : MonoBehaviour
{
    //[SerializeField]
    //private Navigation4Tilemap.Navigation4Tilemap navigation;
    private PolyNavAgent agent;
    public UnityEvent playerMoveEnded = new UnityEvent();

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private SpriteRenderer sprite;

    private bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        //navigation.moveEnded.AddListener(moveEnded);
        agent = GetComponent<PolyNavAgent>();
        agent.OnDestinationReached += OnDestinationReached;
    }

    private void OnDestinationReached()
    {
        animator.SetInteger("state", 0);
        sprite.flipX = false;
        isMoving = false;
        playerMoveEnded.Invoke();
        
    }

    public void MoveTo(Vector3 pos)
    {
        animator.SetInteger("state", 1);
        //navigation.MoveTo(pos);
        isMoving = true;
        agent.SetDestination(pos);
    }

    public void setFight(bool fight)
    {
        if (fight)
        {
            animator.SetInteger("state", 2);
        }
        else
        {
            animator.SetInteger("state", 0);
        }
    }


    public void setSleep(bool slepp)
    {
        //if (fight)
        //{
        //    animator.SetInteger("state", 2);
        //}
        //else
        //{
        //    animator.SetInteger("state", 0);
        //}
    }

    void Update()
    {
        
        
        if (isMoving)
        {

            if (agent.pubCurrentVelocity.x < 0)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
            
            
        }
    }

}
