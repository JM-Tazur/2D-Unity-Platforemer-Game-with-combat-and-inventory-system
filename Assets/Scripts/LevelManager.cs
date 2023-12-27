using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Vector2 playerInitPosition;

    void Start()
    {
        playerInitPosition = FindObjectOfType<HeroKnight>().transform.position;
    }

    public void Restart(bool totalReset)
    {
        //1-Restart The Scene
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName, LoadSceneMode.Single);
        //2-Reset the player position
        //Save the player initial position
        //Reposition
        //FindObjectOfType<HeroKnight>().transform.position = playerInitPosition;
    }
}
