using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SH_Start : MonoBehaviour
{
    [Header("다음 로드할 씬 넘버")]
    public int sceneNum;
    public void OnStartButton()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
