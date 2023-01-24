using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public Vector2 menuSize = new Vector2(2000, 1000);

    public float buttonMinHeight = 300f;

    public Font captionFont;

    public int fontSize;

    public Font buttonFont;

    public string mainMenuText = "Выбор режима";
    public string Level1ButtonText = "Уровень 1";
    public string Level2ButtonText = "Уровень 2";
    public string Level3ButtonText = "Уровень 3";
    public string BackButtonText = "Назад";

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
            if (GUILayout.Button(Level1ButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Level");
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(Level2ButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Level(1)");
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(Level3ButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Level(2)");
            }
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(BackButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Main Menu");
            }
            GUILayout.FlexibleSpace();
        }
        GUILayout.EndArea();
    }
}
