using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    int index;
    int x;
    bool isSinglePlayer;
    public TextMeshProUGUI[] Texts;
    private void Awake()
    {
        index = -1; 
    }
    public void SpawnPlayer()
    {
        if (!isSinglePlayer)
        {
            x++;
            index++;
            CharacterScript derp = PlayerInput.GetPlayerByIndex(index).gameObject.GetComponent<CharacterScript>();
            derp.rows[0] -= 7 * x;
            derp.rows[1] -= 7 * x;
            derp.rows[2] -= 7 * x;
            derp.playerid = index;
            PlayerInput.GetPlayerByIndex(index).gameObject.GetComponent<Score>().Score_text = Texts[index];
            PlayerInput.GetPlayerByIndex(index).gameObject.GetComponent<CharacterController>().enabled = false;
            derp.transform.position = new Vector3(derp.rows[1], 0, 0);
            PlayerInput.GetPlayerByIndex(index).gameObject.GetComponent<CharacterController>().enabled = true;
            Debug.Log("Spawn Player");
        }
        /*else
        {

        }*/
       
    }
}
