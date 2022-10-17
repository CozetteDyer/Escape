using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))// listens for escape key
        {
            QuitGame();
        }
    }
    public void QuitGame()
    {
        /**there are two exit functions in unity
         * one is used for closing the play editor
         * and the other is for closing a built application.
         * Unfortunately there are errors if you try and use both,
         * so instead of commenting and uncommenting out lines
         * we use this preprocessor command to take care of it
         * all at once */

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
