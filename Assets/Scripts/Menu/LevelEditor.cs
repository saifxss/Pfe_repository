using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System;

public enum eRank {
    S_tier,A_tier,B_tier,C_tier
}
[System.Serializable]
public class Levels
{
    public string Track_Name;
    public List<ObstacleObj> Array;
    public AudioClip track;
    public int highScore;
    public eRank rank;
}
[System.Serializable]
public class Maps
{
    public string Map_Name;
    public List<Levels> _levels;
    public Image Map_view;
}
public class LevelEditor : MonoBehaviour
{
    public static LevelEditor levelEditorInstance;
    public Text MapName;
    public Image MapView;
    public List<Maps> maps;
    public Maps currentMap;
    public Levels currentlevel;
    public float _mapNav;
    public float _lvlNav;
    public int indexL;
    public int index;
    public bool CanSpawn;
    public void Awake()
    {
        if (levelEditorInstance != null && levelEditorInstance != this)
            Destroy(this);
        else
            levelEditorInstance = this;

        currentMap = maps[0];
        currentlevel = currentMap._levels[0];
        DontDestroyOnLoad(this.gameObject);
        if (SceneManager.GetActiveScene().name != "UI_Menu")
        {
            CanSpawn = true;
        }
    }
    public void Again()
    {
        transform.GetChild(6).gameObject.SetActive(true);
    }

   

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "UI_Menu")
            displayMap();
        else if (CanSpawn)
        {
            Debug.Log("tesyt");
        }
    }
    public void displayMap()
    {
        MapView = currentMap.Map_view;
        MapName.text = currentMap.Map_Name;
    }
    public void OnMapChange(InputAction.CallbackContext context)
    {
        _mapNav= context.ReadValue<float>();
        if (_mapNav != 0)
        {
            if (_mapNav == -1)
            {
                index = (index != 0 ? index - 1 : maps.Count-1);
                currentMap = maps[index];
            }
            else if (_mapNav == 1)
            {
                index = (index != maps.Count-1 ? index + 1 : 0);
                currentMap = maps[index];
            }
            currentlevel = currentMap._levels[0];
            indexL = 0;
        }

    }
    public void OnLevelChange(InputAction.CallbackContext context)
    {
        _lvlNav = context.ReadValue<float>();
        if (_lvlNav != 0)
        {
            if (_lvlNav == 1)
            {
                indexL = (indexL != 0 ? indexL - 1 : currentMap._levels.Count - 1);
                currentlevel = currentMap._levels[indexL];
            }
            else if (_lvlNav == -1)
            {
                indexL = (indexL != currentMap._levels.Count - 1 ? indexL + 1 : 0);
                currentlevel = currentMap._levels[indexL];
            }
        }
    }
    
    public void OnlevelConfirm(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            SceneManager.LoadScene(currentMap.Map_Name);
            transform.GetChild(5).gameObject.SetActive(false);
            transform.GetChild(6).gameObject.SetActive(false);
        }
    }
}
