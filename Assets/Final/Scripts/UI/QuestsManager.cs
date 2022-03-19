using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsManager : MonoBehaviour
{ 
	public Text questText;
	
	private Queue<string> questsList;

	// Use this for initialization
	void Start()
	{
		questsList = new Queue<string>();
	}
	public void StartQuest(Quest quest)
	{
		questsList.Clear();

		foreach (string thisQuest in quest.questsList)
		{
			questsList.Enqueue(thisQuest);
		}

		DisplayNextQuest();
	}

	public void DisplayNextQuest()
	{
		if (questsList.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = questsList.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		questText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			questText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{

	}

}