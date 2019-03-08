using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickEnemies : MonoBehaviour
{
    public static PickEnemies instance;
    // Start is called before the first frame update
    public Text Level;
    public InputField highscore, enemies;
    public Structure pointer;
    public Toggle[] array_en;


    void Awake()
    {
        //highscore.onEndEdit.AddListener((string f) => { Debug.Log(highscore.text); });

        highscore.onEndEdit.AddListener((string thing2) => { pointer.highscore = System.Int32.Parse(highscore.text); });
        enemies.onEndEdit.AddListener((string thing2) => { pointer.chosen_enemies = System.Int32.Parse(enemies.text); });
        int i = 0;
        foreach(var iterator in array_en)
        {
            int j = i;
            iterator.onValueChanged.AddListener((bool change) => { pointer.enemies[j] = change; });
            i++;
        }
    }
    
    void Start()
    {
        instance = this;
    }

    public void ActivateScreen(Structure thing)
    {
        pointer = thing;
        gameObject.SetActive(true);
        // transform.SetAsLastSibling();
        Debug.Log("# of Enemies Screen Activated GameLevels->Enemies");
        Level.text = "Level : " + thing.level;

        for (int i = 0; i < 5; ++i)
        {
            array_en[i].isOn = thing.enemies[i];
        }

        highscore.text = thing.highscore.ToString();
        enemies.text = thing.chosen_enemies.ToString();
    }

    public void chooseNoEnemies()
    {
        Debug.Log("# of Enemies on GameLevels->Enemies");
    }

    public void chooseEnemies()
    {
        Debug.Log("Which Enemies on GameLevels->Enemies");
    }

    public void SetHighScore()
    {
        Debug.Log("HighScore on GameLevels->Enemies");
    }

    public void ExitButton()
    {
        Debug.Log("Exit on PickEnemies");
        //gameObject.SetActive(false);
        GameLevels.instance.ActivateScreen();
    }

    public void DeactivateScreen()
    {
        gameObject.SetActive(false);
    }


}
