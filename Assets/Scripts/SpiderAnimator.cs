using UnityEngine;
using System.Collections;

public class SpiderAnimator : MonoBehaviour {

    public Animation anim;
    
    void Start() {
        anim = GetComponent<Animation>();
        
        anim.Play("Death");
    }
}
