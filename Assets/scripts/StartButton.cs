using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

    public void StartGameButton(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
        print("Swapping to main scene");
    }
}
