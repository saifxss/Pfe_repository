using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Tuto : MonoBehaviour
{
    public GameObject Track;
    public CharacterScript Player;
    public AudioSource _audio;
    public TextMeshProUGUI _text;
    public float _time;
    private void Awake()
    {
        
        _audio=Track.GetComponent<AudioSource>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterScript>();
        Time.timeScale = 1;
        Player._freez = true;
    }
    private void Update()
    {
        _time = _audio.time;
        if (_audio.time > 3&& _audio.time < 4)
        {
            _text.text = "Press     Q And D To Move     ";
            Player._freez = false;
        }
        if (_audio.time > 5 && _audio.time < 6)
        {
            Debug.Log("x");
            _text.text = " ";
        }
        if(_audio.time > 12 && _audio.time < 13)
        {
            _text.text = "Press     Z To Jump";
        }
        if (_audio.time > 14 && _audio.time < 15)
        {
            _text.text =" ";
        }
        if (_audio.time > 20 && _audio.time < 21)
        {
            _text.text = "Press     S To Slide";
        }
        if (_audio.time > 22 && _audio.time < 23)
        {
            _text.text = " ";
        }
        if (_audio.time > 26 && _audio.time < 27)
        {
            _text.text = "Press     A To Attack";
        }
        if (_audio.time > 34 && _audio.time < 35)
        {
            SceneManager.LoadScene("menu");
            LevelEditor.levelEditorInstance._menu = true;
            LevelEditor.levelEditorInstance.transform.GetChild(0).gameObject.SetActive(true);
            LevelEditor.levelEditorInstance.transform.GetChild(2).gameObject.SetActive(true);
        }
    }

}
