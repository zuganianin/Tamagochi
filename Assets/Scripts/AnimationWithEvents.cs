using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AnimationWithEvents : MonoBehaviour {

    public UnityEvent OnAnimationEnd;
	// Use this for initialization
	
    public void AnimationEnded()
    {
        OnAnimationEnd.Invoke();
    }
}
