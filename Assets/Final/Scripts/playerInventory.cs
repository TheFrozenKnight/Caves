using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInventory : MonoBehaviour
{
    public float health = 1000f;
    public float potions = 0;
    public float healValue = 200f;
    private int damageValue;

    public Slider healthBar;
    public Text potionCount;

    public GameObject damageTextPrefab;
    public Transform damageTextPos;

    private void FixedUpdate()
    {
        healthBar.value =Mathf.Lerp(healthBar.value, health / 1000f, 1f*Time.deltaTime);
        potionCount.text = potions + "x";
    }

    public void heal()
    {
        if (health != 1000f && potions > 0)
        {
            if (health + healValue >= 1000f)
            {
                potions--;
                health = 1000f;
            }
            else
            {
                potions--;
                health += healValue;
            }
        }
    }
    public void damage(DmgInfo dmgInfo)
    {
        damageValue = dmgInfo.dmgValue + Random.Range(-10, 10);

        if (health >= 0f)
        {
            GameObject dmgText = Instantiate(damageTextPrefab, damageTextPos.position, Quaternion.identity);
            dmgText.GetComponent<DamagePopup>().SetUp(damageValue, dmgInfo.textColor);
            if (health - damageValue <= 0f)
            {
                health = 0f;
            }
            else
            {
                health -= damageValue;
            }
        }
    }

    
}
