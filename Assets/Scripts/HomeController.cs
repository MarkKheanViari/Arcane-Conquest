using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HomeController script has just started");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gotoHome()
    {
        SceneManager.LoadScene(SceneData.home);
    }

    public void gotoGameView()
    {
        SceneManager.LoadScene(SceneData.gameview);
    }

    public void gotoCharacterSelection()
    {
        SceneManager.LoadScene(SceneData.characterselection);
    }

    public void gotoLevelSelection()
    {
        SceneManager.LoadScene(SceneData.levelselection);
    }
}
