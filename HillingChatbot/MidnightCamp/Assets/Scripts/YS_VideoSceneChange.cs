using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class YS_VideoSceneChange : MonoBehaviour
{
    VideoPlayer me;

    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        Playing();
    }

    // Update is called once per frame
    void Update()
    {
        if (me.isPaused == true)
        {
            SceneManager.LoadScene("SH_MainScene");
        }
    }

    void Playing()
    {
        me.Play();
    }
}
