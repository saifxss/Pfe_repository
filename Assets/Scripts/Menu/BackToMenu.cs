using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
   public void OnLobby(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
