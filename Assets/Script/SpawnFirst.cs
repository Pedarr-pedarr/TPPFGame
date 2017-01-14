using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnFirst : MonoBehaviour
{

    private Canvas FirstCanvas;
    public GameObject spawn;

    // Use this for initialization
    void Awake()
    {
       // InvokeRepeating(spawn, 0, 5);
    }

    void Start()
    {
        spawn.GetComponent<Image>();
        FirstCanvas.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

        if (FirstCanvas.enabled == true)
        {
            Instantiate(spawn, new Vector2(Random.Range(1, 5),
                Random.Range(-5, 5)),
                Quaternion.identity);

        }
    }
}
