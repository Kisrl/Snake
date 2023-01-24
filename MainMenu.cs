using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Vector2 menuSize = new Vector2(2000, 1000);

    public float buttonMinHeight = 300f;

    public Font captionFont;
    
    public int fontSize;

    public Font buttonFont;

    public string mainMenuText = "Menu";
    public string OnePlayerButtonText = "1 Player";
    public string exitButtonText = "Exit Game";
    public string TwoPlayerButtonText = "2 Players";

    public void OnGUI()
    {
        Rect rect = new Rect(
            Screen.width / 2f - menuSize.x / 2,
            Screen.height / 2f - menuSize.y / 2,
            menuSize.x,
            menuSize.y);

        GUILayout.BeginArea(rect, GUI.skin.textArea);
        {
            GUIStyle captionStyle = new GUIStyle(GUI.skin.label);

            captionStyle.font = captionFont;

            captionStyle.alignment = TextAnchor.MiddleCenter;
            captionStyle.fontSize = 40;

            GUILayout.Label(mainMenuText, captionStyle);

            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.font = buttonFont;
            buttonStyle.margin = new RectOffset(20, 20, 3, 3);
            buttonStyle.fontSize = 40;

            GUILayout.FlexibleSpace();
            if (GUILayout.Button(OnePlayerButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("menu");
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(TwoPlayerButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Level2");
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(exitButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                Application.Quit();
            }
            GUILayout.FlexibleSpace();
        }
        GUILayout.EndArea();
    }
}