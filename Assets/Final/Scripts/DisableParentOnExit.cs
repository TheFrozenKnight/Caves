using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableParentOnExit : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.transform.parent.gameObject.SetActive(false);
    }
}
