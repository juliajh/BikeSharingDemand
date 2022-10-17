using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YS_Fade : MonoBehaviour
{
    public Image fade;
    public float time = 0;
    // üũ
    public bool b_fadeIn = false;
    public bool b_fadeOut = true;

    // Start is called before the first frame update
    void Start()
    {
        fade = GameObject.Find("Fade").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //Scene scene = SceneManager.GetActiveScene();
        //if(scene.name == "YS_MainMenu")
        //{
        if (b_fadeIn == false && time <= 3)
        {
            FadeIn();
        }
        if (b_fadeOut == false && time <= 3)
        {
            FadeOut();
        }
        if (time >= 3 && b_fadeIn == false)
        {
            b_fadeIn = true;
            time = 0;
        }
        if (time >= 3 && b_fadeOut == false)
        {
            b_fadeOut = true;
            time = 0;
        }
        //}
    }

    public void FadeIn()
    {
        time += Time.deltaTime / 3f;

        Color color = fade.color;
        color.a = Mathf.Lerp(1, 0, time);

        fade.color = color;
    }

    public void FadeOut()
    {
        time += Time.deltaTime / 3f;

        Color color = fade.color;
        color.a = Mathf.Lerp(0, 1, time);

        fade.color = color;
    }
}
