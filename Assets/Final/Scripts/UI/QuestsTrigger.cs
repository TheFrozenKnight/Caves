using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsTrigger : MonoBehaviour
{
	public Quest quest;
	public QuestsManager QuestsManager;
    private void OnTriggerStay(Collider other)
    {
        TriggerQuest();
        this.gameObject.SetActive(false);
    }
    public void TriggerQuest()
	{
		QuestsManager.StartQuest(quest);
	}
}