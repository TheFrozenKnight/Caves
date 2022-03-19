using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFinalArea : MonoBehaviour
{
    public QuestsManager QuestsManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            QuestsManager.DisplayNextQuest();
        }
    }
}
