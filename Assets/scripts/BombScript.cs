using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public BoxCollider2D BombBoxCollider;
    public int bombTime;

	// Use this for initialization
	void Start () {
        //BombBoxCollider.transform.position = player character position;
	}
	
	// Update is called once per frame
	void Update () {

        if (bombTime <= 120)
        {
            bombTime += 1;
        }

        else if (bombTime == 121)
        {
            BombBoxCollider.transform.localScale += new Vector3(1.5f, 1.5f, 1.5f);
            bombTime += 1;
        }

        else if (bombTime == 122 || bombTime == 123)
        {
            bombTime += 1;
        }

        else if (bombTime > 123)
        {
            Destroy(gameObject);
        }

    }
}
