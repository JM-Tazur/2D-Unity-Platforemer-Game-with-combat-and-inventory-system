using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatSystem : MonoBehaviour
{
    public int HP;
    public int ATK;
    public int JMP;
    public int SPD;
    public Text HPtext;
    public Text ATKtext;
    public Text JMPtext;
    public Text SPDtext;

    void Reset()
    {
        HP = 100;
        ATK = 30;
        JMP = 1;
        SPD = 1;
    }

    public void AddHP()
    {
        HP += 20;
        UpdateText();
    }

    public void AddATK()
    {
        ATK += 20;
        UpdateText();
    }

    public void AddJMP()
    {
        JMP += 1;
        UpdateText();
    }

    public void AddSPD()
    {
        SPD += 1;
        UpdateText();
    }

    public void UpdateText()
    {
        HPtext.text = "HEALTH: " + HP.ToString();
        ATKtext.text = "ATTACK: " + ATK.ToString();
        JMPtext.text = "JUMP: " + JMP.ToString();
        SPDtext.text = "SPEED: " + SPD.ToString();
    }

    void Start()
    {
        HPtext.text = "HEALTH: " + HP.ToString();
        ATKtext.text = "ATTACK: " + ATK.ToString();
        JMPtext.text = "JUMP: " + JMP.ToString();
        SPDtext.text = "SPEED: " + SPD.ToString();
    }
}
