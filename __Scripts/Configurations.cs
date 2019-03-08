using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configurations : MonoBehaviour
{
    public static Configurations instance; 
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }


    public void ActivateScreen()
    {
        gameObject.SetActive(true);
        Debug.Log("Configurations Screen is activated");
    }

    public void ExitButton()
    {
        Debug.Log("Exit on Configurations");
        PlayScript.instance.ActivateScreen();
    }

    public void EnemiesButton()
    {
        Debug.Log("Enemies on Configurations");
    }

    public void AudioButton()
    {
        Debug.Log("Audio on Configurations");
    }

    public void BackGround()
    {
        Debug.Log("BackGround on Configurations");
    }

}
