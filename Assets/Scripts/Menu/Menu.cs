using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public int index;
    public int indexL;
    public bool _LevelSelection;
    public bool _menu;

    private void Awake()
    {
        _LevelSelection = false;
        _menu = true;
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
            if (!_LevelSelection) {
                if (context.ReadValue<float>() == 1)
                {
                    transform.GetChild(0).GetChild(index).GetChild(1).gameObject.SetActive(false);
                    index = (index != 0 ? index - 1 : 3);
                    transform.GetChild(0).GetChild(index).GetChild(1).gameObject.SetActive(true);
                }
                else if (context.ReadValue<float>() == -1)
                {
                    transform.GetChild(0).GetChild(index).GetChild(1).gameObject.SetActive(false);
                    index = (index != 3 ? index + 1 : 0);
                    transform.GetChild(0).GetChild(index).GetChild(1).gameObject.SetActive(true);
                }
            }
            else
            {
                if (context.ReadValue<float>() == 1)
                {
                    transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition = new Vector3(60, transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition.y,0);
                    indexL = (indexL != 0 ? indexL - 1 : 3);
                    transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition = new Vector3(20, transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition.y, 0);
                }
                else if (context.ReadValue<float>() == -1)
                {
                    transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition = new Vector3(60, transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition.y, 0);
                    indexL = (indexL != 3 ? indexL + 1 : 0);
                    transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition = new Vector3(20, transform.GetChild(5).GetChild(3).GetChild(indexL).transform.localPosition.y, 0);
                }
            }
            
        }
    }
    public void OnLobby(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (LevelEditor.levelEditorInstance.Reload)
            {
                transform.GetChild(6).gameObject.SetActive(false);
                LevelEditor.levelEditorInstance.Reload = false;
                SceneManager.LoadScene("menu");
            }
            
        }
    }
    public void OnConfirm(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (_LevelSelection)
            {
                transform.GetChild(5).gameObject.SetActive(false);
                SceneManager.LoadScene(LevelEditor.levelEditorInstance.currentMap.Map_Name);
                
            }else if (_menu)
            {
                if (index == 0)
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(2).gameObject.SetActive(false);
                    transform.GetChild(5).gameObject.SetActive(true);
                    _LevelSelection = true;
                }
                if (index == 3)
                {
                    Application.Quit();
                }
                _menu = false;
            }
            

        }
    }
}
