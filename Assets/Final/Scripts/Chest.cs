using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private bool isPlayerNear = false;
    private bool isOpen = false;
    public QuestsManager QuestsManager;
    public GameObject item;
    public Transform spawnPoint;
    public GameObject PressE;

    void Update()
    {
        if (!isOpen && isPlayerNear)
        {
            if (Input.GetButtonDown("Interact"))
            {
                OpenChest();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpen && other.tag == "Player")
        {
            PressE.SetActive(true);
            isPlayerNear = true;
        }
    }

	private void OnTriggerExit(Collider other)
	{
        if (!isOpen && other.tag == "Player")
        {
            PressE.SetActive(false);
            isPlayerNear = false;
        }
    }

    private void OpenChest()
    {
        isOpen = true;
        PressE.SetActive(false);
        Instantiate(item, spawnPoint.transform.position, Quaternion.identity);
        GetComponent<Animator>().Play("Open");
        GetComponent<AudioSource>().Play();
        QuestsManager.DisplayNextQuest();
    }
}
