using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public int index;
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
            if (context.ReadValue<float>() ==1)
            {
                transform.GetChild(0).GetChild(index).GetChild(2).gameObject.SetActive(false);
                index = (index != 0 ? index - 1 : 3);
                transform.GetChild(0).GetChild(index).GetChild(2).gameObject.SetActive(true);
            }
            else if (context.ReadValue<float>() == -1)
            {
                transform.GetChild(0).GetChild(index).GetChild(2).gameObject.SetActive(false);
                index = (index != 3 ? index + 1 : 0);
                transform.GetChild(0).GetChild(index).GetChild(2).gameObject.SetActive(true);
            }
        }
    }
    public void OnConfirm(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            if (index == 0)
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(2).gameObject.SetActive(false);
                transform.GetChild(5).gameObject.SetActive(true);
            }
            if (index == 3)
            {
                Application.Quit();
            }

        }
    }
}
