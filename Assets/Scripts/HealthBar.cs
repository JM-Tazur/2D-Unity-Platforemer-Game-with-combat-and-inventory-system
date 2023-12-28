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
        if(health <= 0 || FindObjectOfType<HeroKnight>().IsBlocking() || FindObjectOfType<HeroKnight>().IsRolling())
            return;

        //Reduce health
        health -= value;
        //Play animation
        FindObjectOfType<HeroKnight>().Hurt();
        //Refresh UI bar
        fillbar.fillAmount = health / FindObjectOfType<HeroKnight>().GetMaxHP();
        //Check if health is 0 or less -> dead
        if(health <= 0)
        {
            FindObjectOfType<HeroKnight>().Die();
            Debug.Log("You Died");
        }
    }

    void Start()
    {
        health = FindObjectOfType<HeroKnight>().GetMaxHP();
    }

    private void Update()
    {

    }
}
