using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TamStoriesButton : MonoBehaviour

{
    // Start is called before the first frame update
    public void Button1()
    {
        SceneManager.LoadScene("PlayGround");
    }

    // Update is called once per frame
    public void Button2()
    {
        SceneManager.LoadScene("Scene1");

    }
    public void Back()
    {
        SceneManager.LoadScene("PlayGround");

    }


}

