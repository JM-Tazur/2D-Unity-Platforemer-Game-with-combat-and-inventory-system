using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillbar;
    public float health;

    public void LoseHealth(int value)
    {
        //Do nothing if dead
        if(health <= 0)
            return;

        //Reduce health
        health -= value;
        //Refresh UI bar
        fillbar.fillAmount = health / 100;
        //Check if health is 0 or less -> dead
        if(health <= 0)
        {
            FindObjectOfType<HeroKnight>().Die();
            Debug.Log("You Died");
        }
    }

    private void Update()
    {

    }
}
