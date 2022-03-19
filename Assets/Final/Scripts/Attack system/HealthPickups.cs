using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour
{ 
    playerInventory player;
    float rotY;

    private void Start()
    {
        player = FindObjectOfType<playerInventory>();
    }
    void FixedUpdate()
    {
        rotY -= .75f;
        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.potions++;
            this.gameObject.SetActive(false);
        }
    }
}
