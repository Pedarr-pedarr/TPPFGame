using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Animator ani, TriangleCanvas;
    public Canvas canvasLevel;
    public Button play;
    public Button Back;

    // Use this for initialization
    void Start()
    {
        play = play.GetComponent<Button>();
        canvasLevel.enabled = false;
        ani.enabled = false;
        TriangleCanvas.enabled = false;
        Back.enabled= false;

    }

    // Update is called once per frame
    public void Press()
    {
        ani.enabled = true;
        canvasLevel.enabled = true;
        TriangleCanvas.enabled = true;
        Back.enabled = true;

    }
}
