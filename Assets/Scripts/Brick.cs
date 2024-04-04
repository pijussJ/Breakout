using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField]private int hp;
    public ParticleSystem ps;
    public int score = 100;
    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
            ps.Play();
            Destroy(gameObject);
            GameManager.score += score;
        }
    }
}
