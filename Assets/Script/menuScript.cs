using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class menuScript : MonoBehaviour {

    public Canvas QuitMenu;
    public Button startText, ExitText;

    // Use this for initialization
    void Start () {
        QuitMenu = QuitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        ExitText = ExitText.GetComponent<Button>();
        QuitMenu.enabled = false;
    }

    public void ExitPress()
    {
        QuitMenu.enabled = true;
        startText.enabled = false;
        ExitText.enabled = false;
    }

    public void NoPress()
    {
        QuitMenu.enabled = false;
        startText.enabled = true;
        ExitText.enabled = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
