using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    public static StartScreenScript instance;

    void Awake()
    {
       instance = this;
    }
    public void StartScreenPlay()
    {
        Debug.Log("Play Button On Start Screen");
        gameObject.SetActive(false);
    }

    public void StartScreenExit()
    {
        Debug.Log("Exit Button On Start Screen");
    }

    public void ActivateScreen()
    {
        Debug.Log("Activate Start Screen");
        gameObject.SetActive(true);
    }
}
