using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour
{   
    private GameLevels obj;
    public static PlayScript instance;

    void Awake()
    {
        instance = this;
    }

    public void ExitButton()
    {
        Debug.Log("Exit on Dare To Play");
        StartScreenScript.instance.ActivateScreen();
    }

    public void PlayGameButton()
    {
        Debug.Log("Play on Dare To Play");
        //uhhhhh what do I do now?
    }

    public void HistoryButton()
    {
        Debug.Log("History on Dare To Play");
        //uhhhhh what do I do now?
    }

    public void ConfigurationsButton()
    {
        Debug.Log("Configurations on Dare To Play");
        gameObject.SetActive(false);
        GameLevels.instance.DeactivateScreen();
        PickEnemies.instance.DeactivateScreen();
        Configurations.instance.ActivateScreen();
        //uhhhhh what do I do now?
    }

    public void GameLevelsButton()
    {
        Debug.Log("GameLevels on Dare To Play");
        gameObject.SetActive(false);
        GameLevels.instance.ActivateScreen();
        //uhhhhh what do I do now?
    }

    public void ActivateScreen()
    {
        gameObject.SetActive(true);
    }


}
