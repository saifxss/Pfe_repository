using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public int gridId;
    public GameObject Track;
    public GameObject _ItemPrefab;
    public List<GameObject> itemList;
    public float Bpm;
    public int nb;
    public float bps;
    public AudioSource audioSource;
    GridLayoutGroup grid;
    public GameObject Manager;
    private void Awake()
    {
        
        audioSource = Track.GetComponent<AudioSource>();
        grid = GetComponent<GridLayoutGroup>();
    }
    private void Start()
    {
        Bpm = 120;
    }
    private void Update()
    {
        
        bps = 60/Bpm;
        nb = Mathf.RoundToInt(audioSource.clip.length / bps);
        grid.cellSize= new Vector2(bps*20,grid.cellSize.y);
        if (nb != itemList.Count)
            StartCoroutine(FixList());
    }

    IEnumerator FixList()
    {
        if (itemList.Count < nb)
        {
            GameObject x = Instantiate(_ItemPrefab, gameObject.transform, false);
            if(gridId!=0)
                x.GetComponent<Item_Holder>().item.pos = (gridId == 1 ? ePosition.Mid : ePosition.Right);
            itemList.Add(x);
        }else if (itemList.Count > nb)
        {
            for(int i=(itemList.Count-nb); i < itemList.Count; i++)
            {
                GameObject x = itemList[i];
                itemList.RemoveAt(i);
                Destroy(x);
            }
        }
        yield return new WaitUntil(() => nb != itemList.Count);
    }
}
