using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SH_FileManager : MonoBehaviour
{
    private string path;
    public RawImage rawImage;
    SH_TypingEffect typing;
    public static string face;
    private string url = "http://127.0.0.1:7700/";
    
    private void Start()
    {
        typing = GetComponent<SH_TypingEffect>();
    }

    public void OpenfileExplorer()
    {
        // image path
        path = EditorUtility.OpenFilePanel("Show all images (.jpg)", "", "jpg");
        StartCoroutine(GetTexture());
        StartCoroutine(faceExpression());
    }

    IEnumerator GetTexture()
    {
        // connection string
        // UnityWebRequestTexture : provides the DownloadHandlerTexture class to use UnityWebRequest to download Textures
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file:///" + path);
        //print(path);

        // ������� ������
        yield return www.SendWebRequest();

        // ������ ���� ���
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        // ������ ���� ���
        else
        {
            Texture myTexture = ((DownloadHandlerTexture )www.downloadHandler).texture;
            rawImage.texture = myTexture;
            yield return new WaitForSeconds(1);
            typing.isUpload = true;
        }
    }
    
    IEnumerator faceExpression()
    {
        string faceUrl = url + "faceExpression";
        
        using(UnityWebRequest webRequest = UnityWebRequest.Get(faceUrl))
        {
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError)
            {
                Debug.Log("Error: "+webRequest.error);
            }
            else
            {
                //face = webRequest.downloadHandler.text;
                face = "Sad";
            }
        }
        
    }
}
