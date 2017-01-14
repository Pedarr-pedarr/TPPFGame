using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InitAnimation : MonoBehaviour
{

    public GameObject BlackTriangle, WhiteTriangle, RightCircle, LeftCircle, BottomCircle;
    private float speed = .4f;
    private float countdownTriangle = 2f;
    private float countdownCircle = 3f;
    public Button Play, Exit;
    private Vector3 vectorCircle = new Vector3(.55f, .55f, 1f);
    private Vector3 vectorTriangle = new Vector3(2.5f, 2.5f, 1f);
    public CanvasGroup cnv;

    // Use this for initialization

    void Start()
    {
        StartCoroutine("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        countdownTriangle -= Time.deltaTime;
        countdownCircle -= Time.deltaTime;

        
        if (countdownTriangle < 0)
        {
            
            BlackTriangle.transform.Rotate(0f, 0f, .2f);
            WhiteTriangle.transform.Rotate(0f, 0f, -.2f);
            BlackTriangle.transform.localScale = Vector3.Lerp(BlackTriangle.transform.localScale, vectorTriangle, speed * Time.deltaTime);
            WhiteTriangle.transform.localScale = Vector3.Lerp(WhiteTriangle.transform.localScale, vectorTriangle, speed * Time.deltaTime);
        }

        if (countdownCircle < 0)
        {
            RightCircle.transform.localScale = Vector3.Lerp(RightCircle.transform.localScale, vectorCircle, speed * Time.deltaTime);
            LeftCircle.transform.localScale = Vector3.Lerp(LeftCircle.transform.localScale, vectorCircle, speed * Time.deltaTime);
            BottomCircle.transform.localScale = Vector3.Lerp(BottomCircle.transform.localScale, vectorCircle, speed * Time.deltaTime);
            Play.interactable = true;
            Exit.interactable = true;
        }

    }

    IEnumerator FadeIn()
    {
        cnv.alpha = 0;
        float time = 4f;
     
            while (cnv.alpha < 1)
            {
                cnv.alpha += Time.deltaTime / time;
                yield return null;
            }
        }
    }
