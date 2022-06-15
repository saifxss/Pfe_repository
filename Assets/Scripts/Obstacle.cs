using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Obstacles
{
    public enum obstcale
    {
        up,down,block,Wall
    }
}

public class Obstacle : MonoBehaviour
{

    public Obstacles.obstcale _obstacle;
    public int block;
    public float speed;
    public CharacterScript Player;

    private void Start()
    {
        speed = 30;
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterScript>();
    }

    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            if (_obstacle != Obstacles.obstcale.block)
            {
                Player.PlayerChancesN();

                if (other.GetComponent<CharacterScript>()._ability != Ability.ability.Shield)
                {
                    Score.scoreMulti = 1;
                }
                else
                {
                    other.GetComponent<CharacterScript>()._ability = Ability.ability.None;
                }
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {               
                if ((other.GetComponent<CharacterScript>()._firstAttack)&& block == 1)
                {
                    //addscore and destroy gameobject
                    Score.scoreMulti += 1;
                    Player.PlayerChancesP();
                    Score._score += 10 * other.GetComponent<Score>()._x2 * Score.scoreMulti;
                    Destroy(gameObject);
                    return;
                }
                if ((other.GetComponent<CharacterScript>()._secondAttack)&& block == 2)
                {
                    Score.scoreMulti += 1;
                    Player.PlayerChancesP();
                    Score._score += 10 * other.GetComponent<Score>()._x2 * Score.scoreMulti;
                    Destroy(gameObject);
                    return;
                }
                if ((other.GetComponent<CharacterScript>()._thirdAttack)&& block == 3)
                {
                    Score.scoreMulti += 1;
                    Player.PlayerChancesP();
                    Score._score += 10 * other.GetComponent<Score>()._x2* Score.scoreMulti;
                    Destroy(gameObject);
                    return;
                }
                
            }
        }else if(other.gameObject.tag == "Finish")
        {
            if (_obstacle == Obstacles.obstcale.block)
            {
                Score.scoreMulti = 1;
                Player.StartCoroutine(Player.turnRedEffect());
                Player.PlayerChancesN();
            }
            else
            {
                Score.scoreMulti += 1;
                Score._score += 10  * Score.scoreMulti;
                Player.PlayerChancesP();
            }
                Destroy(gameObject);
        }

    }

}
