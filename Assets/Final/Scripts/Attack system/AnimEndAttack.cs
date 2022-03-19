using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEndAttack : StateMachineBehaviour
{
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.GetComponent<AnimatorEvents>().EnableMove();
        animator.transform.GetComponent<AnimatorEvents>().PlayerSword.GetComponent<BoxCollider>().enabled = false;

    }
}
