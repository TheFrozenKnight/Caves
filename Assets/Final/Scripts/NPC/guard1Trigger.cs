using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard1Trigger : MonoBehaviour
{
    private bool isPlayerNear = false;
    private bool istriggered = false;
    public DialogueTrigger DialogueTrigger;
    public QuestsManager QuestsManager;
    public GameObject sword;
    public GameObject icon;
    public GameObject wall;
    public GameObject PressE;

    void Update()
    {
        if (!istriggered && isPlayerNear)
        {
            if (Input.GetButtonDown("Interact"))
            {
                speak();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!istriggered && other.tag == "Player")
        {
            PressE.SetActive(true);
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!istriggered && other.tag == "Player")
        {
            PressE.SetActive(false);
            isPlayerNear = false;
        }
    }

    private void speak()
    {
        istriggered = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        sword.SetActive(true);
        icon.SetActive(false);
        wall.SetActive(false);
        PressE.SetActive(false);
        DialogueTrigger.TriggerDialogue();
        QuestsManager.DisplayNextQuest();
    }
}
