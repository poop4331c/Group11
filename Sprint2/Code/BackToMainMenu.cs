using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public string mainMenuScene;

    public void BackToMain()
    {
        SceneManager.LoadScene(mainMenuScene);
    }
}
