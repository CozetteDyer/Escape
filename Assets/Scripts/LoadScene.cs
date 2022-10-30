using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    /**
     * Loads start Scene
     */
    public void loadStart()
    {
        SceneManager.LoadScene("Start Screen");
    }

    /**
     * Loads 1st Room Scene
     */
    public void loadRoom1()
    {
        SceneManager.LoadScene("1st room");
    }

    /**
     * Loads 2nd Room Scene
     */
    public void loadRoom2()
    {
        SceneManager.LoadScene("2nd room");
    }

    /**
     * Loads 3rd Room Scene
     */
    public void loadRoom3()
    {
        SceneManager.LoadScene("3rd room");
    }

    /**
     * Loads Death Scene
     */
    public void loadDeathScene()
    {
        SceneManager.LoadScene("death Scene");
    }

    /**
     * Loads Options Scene
     */
    public void loadOptionsScene()
    {
        SceneManager.LoadScene("Options Scene");
    }

    /**
     * Loads Credits Scene
     */
    public void loadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
}
