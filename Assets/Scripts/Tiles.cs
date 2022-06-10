using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    public float timetoDestroy;
    private void Awake()
    {
        Destroy(gameObject, timetoDestroy);
    }

    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * 15f);
    }
}
