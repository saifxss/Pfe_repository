using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Save
{
    public string FileName;
    public List<Item> Array;
    public float _BpmValue;

    public Save(string fileName, List<Item> array, float bpmValue)
    {
        FileName = fileName;
        Array = array;
        _BpmValue = bpmValue;
    }
}
public class Selector : MonoBehaviour
{
    public float bpm;
    int m;
    int c;
    int l;
    float _ic;
    float _id;
    int maxC;
    public GameObject Items;
    public GameObject array;
    public GameObject save_prefab;
    public GameObject SaveList;
    public TextMeshProUGUI text;
    float _bpmchange;
    float _bpmNav;
    float _inav;
    float _navH;
    float _navV;
    float _Scroll;
    public PlayerInput ActionMap;
    public Scrollbar scrollbar;
    public List<Item> templist;
    bool nzeltSave;
    public bool deleteModeOnStart = false;
    private void Awake()
    {
        bpm = 100;
        if(deleteModeOnStart)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("LastSavedIndex", -1);
            PlayerPrefs.Save();
        }
        if(!PlayerPrefs.HasKey("LastSavedIndex"))
        {
            PlayerPrefs.SetInt("LastSavedIndex", -1);
            PlayerPrefs.Save();
        }
        LoadSaves();
    }

    public void Update()
    {
        text.text = "Bpm :"+bpm.ToString();
    }
    public void OnScroll(InputAction.CallbackContext context)
    {
        _Scroll = context.ReadValue<float>();
        if (_Scroll != 0)
        {

            if (_Scroll == 1)
            {
                scrollbar.value = (scrollbar.value != 0 ? scrollbar.value - 0.1f : 1);
            }
            else if (_Scroll == -1)
            {
                scrollbar.value = (scrollbar.value != 1 ? scrollbar.value + 0.1f : 0);
            }
        }
    }

    public void OnbpmNav(InputAction.CallbackContext context)
    {
        _bpmNav= context.ReadValue<float>();
        if (_bpmNav != 0)
        {
            
            if (_bpmNav == 1)
            {
                bpm = (bpm != 60 ? bpm - 10 : 240);
            }else if (_bpmNav == -1)
            {
                bpm = (bpm != 240 ? bpm + 10 : 60);
            }
        }
    }
    public void OnBpmChange(InputAction.CallbackContext context)
    {
        _bpmchange = context.ReadValue<float>();
        if (_bpmchange != 0)
        {
            scrollbar.value = 0;
            maxC = array.transform.GetChild(0).GetComponent<Grid>().nb - 1;
            array.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
            array.transform.GetChild(0).GetComponent<Grid>().Bpm = bpm;
            array.transform.GetChild(1).GetComponent<Grid>().Bpm = bpm;
            array.transform.GetChild(2).GetComponent<Grid>().Bpm = bpm;
        }

    }
    public void OnItemNav(InputAction.CallbackContext context)
    {
        _inav = context.ReadValue<float>();
        if(_inav != 0)
        {
            if (_inav == -1)
            {
                //scrollbar.value = scrollbar.value - 0.1f;
                Items.transform.GetChild(m).GetChild(0).gameObject.SetActive(false);
                m = (m != 0 ? m - 1 : 5);
                Items.transform.GetChild(m).GetChild(0).gameObject.SetActive(true);
            }
            else if (_inav == 1)
            {
                //scrollbar.value = scrollbar.value+0.1f;
                Items.transform.GetChild(m).GetChild(0).gameObject.SetActive(false);
                m = (m != 5 ? m + 1 : 0);
                Items.transform.GetChild(m).GetChild(0).gameObject.SetActive(true);
            }
        }
    }
    public void OnNavVer(InputAction.CallbackContext context)
    {
        _navV = context.ReadValue<float>();
        if (_navV != 0)
        {
            if (_navV == -1)
            {
                array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(false);
                c = (c != 0 ? c - 1 : maxC);
                array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(true);
            }
            else if (_navV == 1)
            {
                array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(false);
                c = (c != maxC ? c + 1 : 0);
                array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(true);
            }
        }
    }
    public void OnNavHor(InputAction.CallbackContext context)
    {
        _navH = context.ReadValue<float>();
        if (_navH == -1)
        {
            array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(false);
            l = (l != 0 ? l - 1 : 2);
            array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(true);
        }
        else if (_navH == 1)
        {
            array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(false);
            l = (l != 2 ? l + 1 : 0);
            array.transform.GetChild(l).GetChild(c).GetChild(1).gameObject.SetActive(true);
        }
    }
    public void OnItemConfirm(InputAction.CallbackContext context)
    {
        _ic=context.ReadValue<float>();
        if(_ic != 0){
            array.transform.GetChild(l).GetChild(c).GetChild(0).GetComponent<RawImage>().texture = Items.transform.GetChild(m).GetComponent<RawImage>().texture;
            array.transform.GetChild(l).GetChild(c).GetComponent<Item_Holder>().item= Items.transform.GetChild(m).GetComponent<Item_Holder>().item;
        }
    }
    public void OnBackToMenu(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>()!=0)
        {
            LevelEditor.levelEditorInstance._menu=true;
            LevelEditor.levelEditorInstance.transform.GetChild(0).gameObject.SetActive(true);
            LevelEditor.levelEditorInstance.transform.GetChild(2).gameObject.SetActive(true);
            SceneManager.LoadScene("menu");
        }
    }
    public void OnItemDelete(InputAction.CallbackContext context)
    {
        _id = context.ReadValue<float>();
        if (_id != 0)
        {
            array.transform.GetChild(l).GetChild(c).GetChild(0).GetComponent<RawImage>().texture =null ;
            array.transform.GetChild(l).GetChild(c).GetComponent<Item_Holder>().item =null;
        }
    }
    public void OnSave(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {
            templist = new List<Item>(0);
            for (int i = 0; i < maxC; i++)
            {
                templist.Add(array.transform.GetChild(0).GetChild(c).GetComponent<Item_Holder>().item);
                templist.Add(array.transform.GetChild(1).GetChild(c).GetComponent<Item_Holder>().item);
                templist.Add(array.transform.GetChild(2).GetChild(c).GetComponent<Item_Holder>().item);
            }

            if (!nzeltSave)
            {
                int countSaved = PlayerPrefs.GetInt("LastSavedIndex");
                countSaved++;
                Save s = new Save("SavedCustom" +countSaved, templist, bpm);
                PlayerPrefs.SetInt("LastSavedIndex", countSaved);
                nzeltSave = true;
                string saveJson = JsonUtility.ToJson(s);
                Debug.Log(saveJson);
                PlayerPrefs.SetString(s.FileName, saveJson);
            } else
            {
                int countSaved = PlayerPrefs.GetInt("LastSavedIndex");
                Save s = new Save("SavedCustom" + countSaved, templist, bpm);
                string saveJson = JsonUtility.ToJson(s);
                Debug.Log(saveJson);
                PlayerPrefs.SetString(s.FileName, saveJson);
            }
        }
    }

    void LoadSaves()
    {
        int countSaved = PlayerPrefs.GetInt("LastSavedIndex") + 1;
        Debug.Log(countSaved);
        for(int i = 0; i<countSaved; i++)
        {
            GameObject x = Instantiate(save_prefab, SaveList.transform.GetChild(0).GetChild(0).GetChild(0));
            //x.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = ("SavedCustom" + i);
            string sTemp = PlayerPrefs.GetString("SavedCustom" + i);
            Debug.Log(sTemp);
            Save sTempInstance = JsonUtility.FromJson<Save>(sTemp);
            for (int j = 0; j < sTempInstance.Array.Count; j++)
            {
                Debug.Log(sTempInstance.Array[j].name + " pos : " + sTempInstance.Array[j].pos + " time: " + sTempInstance.Array[j].time);
            }

        }
    }

    /*void OnClickLoadedSave()
    {
        for (int j = 0; j < sTempInstance.Array.Count; j++)
        {
            array.transform.GetChild(((int)sTempInstance.Array[j].pos)).GetChild(j).GetComponent<Item_Holder>().item = sTempInstance.Array[j];
        }
    }*/

    public void OnLoad(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() != 0)
        {

        }
    }

}
