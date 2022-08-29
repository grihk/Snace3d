using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Vector2 menuSize = new Vector2(250, 350);

    public float buttonMinHeight = 60f;

    public Font captionFont;
    public Font buttonFont;
    public string mainMenuText = "Menu";
    public string startButtonText = "Start Game";
    public string exitButtonText = "Exit Game";
    public void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2f - menuSize.x / 2, Screen.height / 2f - menuSize.y / 2, menuSize.x, menuSize.y);
        GUILayout.BeginArea(rect, GUI.skin.textArea);
        {
            GUIStyle captionStyle = new GUIStyle(GUI.skin.label);
            captionStyle.font = captionFont;
            captionStyle.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label(mainMenuText, captionStyle);
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
            buttonStyle.font = buttonFont;
            buttonStyle.margin = new RectOffset(20, 20, 3, 3);
            GUILayout.FlexibleSpace();
            if (GUILayout.Button(startButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight)))
            {
                SceneManager.LoadScene("Game");
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

