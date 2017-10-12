using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

    private void PlayerDeath(string startScreen)
    {
        SceneManager.LoadScene(startScreen);
        print("Swapping to main scene");
    }

    // Use this for initialization
    void Start () {
        playerCurrentHealth = playerMaxHealth;

		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            PlayerDeath("Start Menu");
        }

	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
