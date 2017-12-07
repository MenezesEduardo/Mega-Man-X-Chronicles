using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robo_amarelo : MonoBehaviour {

    public PlayerControler player;
    public int lifepoints;
    public Animator anim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lifepoints <= 0)
        {
            anim.SetBool("Destroy", true);

        }
    }

    public void destruction()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.AddLifePoints(-1);
        }
        if (other.gameObject.tag == "Projetil_X_min")
        {
            lifepoints = lifepoints - 1;
        }
        if (other.gameObject.tag == "Projetil_X_med")
        {
            lifepoints = lifepoints - 2;
        }
        if (other.gameObject.tag == "Projetil_X_max")
        {
            lifepoints = lifepoints - 4;
        }
    }
}
