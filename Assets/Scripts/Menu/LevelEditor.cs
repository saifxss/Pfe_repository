using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System;
using TMPro;

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
    public bool Locked;
}
[System.Serializable]
public class Maps
{
    public string Map_Name;
    public List<Levels> _levels;
    public RawImage Map_view;
}
public class LevelEditor : MonoBehaviour
{
    public static LevelEditor levelEditorInstance;
    public TextMeshProUGUI MapName;
    public RawImage MapView;
    public TextMeshProUGUI[] TrackName;
    public List<Maps> maps;
    public Maps currentMap;
    public Levels currentlevel;
    public float _mapNav;
    public float _lvlNav;
    public int indexL;
    public int index;
    public bool CanSpawn;
    public bool Reload;
    public int index1;
    public int index2;
    public bool _LevelSelection;
    public bool _menu;
    
    public void Awake()
    {
        _LevelSelection = false;
        _menu = true;
        if (levelEditorInstance != null && levelEditorInstance != this)
            Destroy(gameObject);
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
        Reload = true;
        transform.GetChild(6).gameObject.SetActive(true);
    }

   

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "menu")
            displayMap();
        else if (CanSpawn)
        {
            Debug.Log("tesyt");
        }
    }
    public void displayMap()
    {
        MapView.texture = currentMap.Map_view.texture;
        MapName.text = currentMap.Map_Name;
        for (int i = 0; i < currentMap._levels.Count; i++)
        {
            TrackName[i].text= currentMap._levels[i].Track_Name;
        }

        
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
            index2 = 0;
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

    public void OnPress(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            transform.GetChild(0).GetComponent<Animator>().SetTrigger("Press");
            transform.GetChild(2).GetChild(1).GetComponent<Animator>().SetTrigger("Press");

        }
    }
    public void OnNav(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (!_LevelSelection)
            {
                if (context.ReadValue<float>() == 1)
                {
                    transform.GetChild(0).GetChild(index1).GetChild(1).gameObject.SetActive(false);
                    index1 = (index1 != 0 ? index1 - 1 : 3);
                    transform.GetChild(0).GetChild(index1).GetChild(1).gameObject.SetActive(true);
                }
                else if (context.ReadValue<float>() == -1)
                {
                    transform.GetChild(0).GetChild(index1).GetChild(1).gameObject.SetActive(false);
                    index1 = (index1 != 3 ? index1 + 1 : 0);
                    transform.GetChild(0).GetChild(index1).GetChild(1).gameObject.SetActive(true);
                }
            }
            else
            {
                if (context.ReadValue<float>() == 1)
                {
                    transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(60, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
                    index2 = (index2 != 0 ? index2 - 1 : 3);
                    transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(20, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
                }
                else if (context.ReadValue<float>() == -1)
                {
                    transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(60, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
                    index2 = (index2 != 3 ? index2 + 1 : 0);
                    transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(20, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
                }
            }

        }
    }
    public void OnLobby(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (Reload)
            {
                transform.GetChild(6).gameObject.SetActive(false);
                Reload = false;
                SceneManager.LoadScene("menu");
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(2).gameObject.SetActive(true);
                _menu = true;
                _LevelSelection = false;
            }

        }
        
    }
    IEnumerator Shake()
    {
        transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(0, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
        yield return new WaitForSeconds(0.5f);
        transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition = new Vector3(60, transform.GetChild(5).GetChild(3).GetChild(index2).transform.localPosition.y, 0);
    }
    public void OnConfirm(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (_LevelSelection)
            {
                
                if (!currentlevel.Locked)
                {
                    transform.GetChild(5).gameObject.SetActive(false);
                    SceneManager.LoadScene(currentMap.Map_Name);
                }
                else
                {
                    StartCoroutine(Shake());
                }
                    

            }
            else if (_menu)
            {
                if (index1 == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(2).gameObject.SetActive(false);
                    transform.GetChild(5).gameObject.SetActive(true);
                    _LevelSelection = true;
                }
                if (index1 == 3)
                {
                    Application.Quit();
                }
                _menu = false;
            }


        }
    }
}
