using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playLevels : MonoBehaviour
{

    // Use this for initialization
    public void Load1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void Load2()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void Load3()
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
}
