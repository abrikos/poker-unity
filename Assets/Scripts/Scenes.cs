using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public string ListScene, PlayScene;
    public void playGame()
    {
        SceneManager.LoadScene(PlayScene);
    }

    public void goToList()
    {
        SceneManager.LoadScene(ListScene);
    }
}
