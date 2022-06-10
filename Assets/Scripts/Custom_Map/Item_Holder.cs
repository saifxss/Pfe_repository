using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ePosition
{
    Left, Mid, Right
}
[System.Serializable]
    public class Item
    {
        public string name;
        public GameObject _Prefab;
        public Image image;
        public ePosition pos;
        public float time;
        public float speed;
    }

public class Item_Holder : MonoBehaviour
{
    public Item item;
    
}
