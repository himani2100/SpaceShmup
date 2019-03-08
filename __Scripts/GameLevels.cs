using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevels : MonoBehaviour
{
   public static GameLevels instance;
    // Start is called before the first frame update

    public List<Structure> settings;


    void Start()
    {
        instance = this;
    }

    public void Gold()
    {
        Debug.Log("Gold on GameLevels");
        DeactivateScreen();
       // transform.SetAsLastSibling();
        PickEnemies.instance.ActivateScreen(settings[2]);
    }

    public void Silver()
    {
         DeactivateScreen();
       // transform.SetAsLastSibling();
        Debug.Log("Silver on GameLevels");
        PickEnemies.instance.ActivateScreen(settings[1]);
    }

    public void Bronze()
    {
         DeactivateScreen();
        //transform.SetAsLastSibling();
        Debug.Log("Bronze on GameLevels");
        PickEnemies.instance.ActivateScreen(settings[0]);
    }

    public void ExitButton()
    {
        Debug.Log("Exit on GameLevels");
        PlayScript.instance.ActivateScreen();
    }

    public void DeactivateScreen()
    {
        gameObject.SetActive(false);
    }

    public void ActivateScreen()
    {
        Debug.Log("GameLevels Screen is active");
        gameObject.SetActive(true);
    }


}
