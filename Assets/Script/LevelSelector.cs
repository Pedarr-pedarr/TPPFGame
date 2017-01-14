using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

    public Canvas FirstCanvas, SecondCanvas, ThirdCanvas;
    public Button first, second, third;

    // Use this for initialization
    void Start () {

        FirstCanvas = FirstCanvas.GetComponent<Canvas>();
        SecondCanvas = SecondCanvas.GetComponent<Canvas>();
        ThirdCanvas = ThirdCanvas.GetComponent<Canvas>();
        first = first.GetComponent<Button>();
        second = second.GetComponent<Button>();
        third = third.GetComponent<Button>();
        FirstCanvas.enabled = false;
        SecondCanvas.enabled = false;
        ThirdCanvas.enabled = false;
    }

    public void FirstPress()
    {
        FirstCanvas.enabled = true;
        SecondCanvas.enabled = false;
        ThirdCanvas.enabled = false;
    }

    public void SecondPress()
    {
        FirstCanvas.enabled = false;
        SecondCanvas.enabled = true;
        ThirdCanvas.enabled = false;
    }

    public void ThirdPress()
    {
        FirstCanvas.enabled = false;
        SecondCanvas.enabled = false;
        ThirdCanvas.enabled = true;
    }
}
