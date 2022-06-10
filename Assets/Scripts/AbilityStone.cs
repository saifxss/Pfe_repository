using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ability
{
    public enum ability
    {
        None,X2boost, Inv, Shield, Freeze
    }
}
public class AbilityStone : MonoBehaviour
{
    public float speed;
    public Ability.ability ability;
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        //Destroy(gameObject, 10f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            other.GetComponent<CharacterScript>()._ability = ability;
    }
}
