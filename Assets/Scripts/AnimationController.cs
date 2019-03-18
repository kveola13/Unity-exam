using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public Animation anim;
    public void Start()
    {
        Stop();
    }
    public void Stop()
    {
        anim.Stop();
    }

}
