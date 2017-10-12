using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombWallScript : MonoBehaviour {

    public BoxCollider2D BombWall;
    public bool HitByBomb;

	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {

        if (HitByBomb)
        {
            Destroy(BombWall.gameObject);
            print("Destroying the wall!");
        }
        else if (HitByBomb == false)
        {
            print("I can't destroy the wall!");
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            print("A bomb is hitting the wall!");
            HitByBomb = true;
        }
        else
        {
            HitByBomb = false;
        }
    }
}
