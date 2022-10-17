using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class SH_Net : MonoBehaviour
{
    private string url = "http://127.0.0.1:5001/";

    public Text text; //사용자 input
    public InputField inputField;
    
    public Button inputButton;
    public string chatRequest = null;
    public Text doona;
    public Text chatBot;
    public bool buttonOn = false;
    public AudioSource audios;

    public GameObject sad;
    public GameObject neutral;
    public GameObject happy;
    private bool init = true;
    
    private void Start()
    {
        print(SH_FileManager.face);
        doona.gameObject.SetActive(true);
        inputField.gameObject.SetActive(true);
        inputButton.gameObject.SetActive(true);
        chatBot.gameObject.SetActive(false);
        
    }

    float currTime = 0;
    float currTime2 = 0;  // 답변 받은 뒤 다시 대화 시작하기까지
    float getRequestTime = 8;  // 답변 받는 시간
    float delayTime = 2;

    // 답변 대기 시간
    float currentTime;
    bool curTime;
    
    private void Update()
    {
        // 만약 버튼이 눌리면 챗봇 + 답변 출력
        if (buttonOn)
        {
            doona.gameObject.SetActive(false);
            inputField.gameObject.SetActive(false);
            inputButton.gameObject.SetActive(false);
        }
        
        if (chatRequest!= null && chatRequest.Length > 0)
        {
            chatBot.gameObject.SetActive(true);
            chatBot.text = "오늘 하루 봇: " + chatRequest;
            currTime2 += Time.deltaTime;

            // 대기 꺼주기
            curTime = false;
        }
        if (currTime2 > delayTime)
        {
            doona.gameObject.SetActive(true);
            inputField.gameObject.SetActive(true);
            inputButton.gameObject.SetActive(true);
            chatBot.gameObject.SetActive(false);
            //inputField = null;
            chatRequest = null;
            buttonOn = false;
            inputField.text = "";
            currTime2 = 0;
        }
        
        if(curTime == true)
        {
            RequestDelay();
        }

        // 표정 변화
        if(chatRequest.Contains("잊지말고"))
        {
            sad.gameObject.SetActive(false);
        }
    }


    // 사용자 입력 후 버튼 누름
    public void Btn()
    {
        buttonOn = true;

        if (init)
        {
            neutral.gameObject.SetActive(true);
            chatRequest = "오늘 무슨 일 있었어? 표정이 안 좋네..";
            init = false;
        }
        else
        {
            sad.gameObject.SetActive(true);
            neutral.gameObject.SetActive(false);
            StartCoroutine(chat(text.text));
            curTime = true;
        }

    }

    IEnumerator chat(string userChat)
    {
        string chatWithUser = url + "chatbot";
        WWWForm form = new WWWForm();
        form.AddField("chat", userChat);
        using (UnityWebRequest request = UnityWebRequest.Post(chatWithUser, form))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                Debug.Log(request.error);  
            // 응답을 받으면 
            else
            {
                chatRequest=request.downloadHandler.text;  // 챗봇 답변
                StartCoroutine(voice());
            }
        }
    }

    IEnumerator voice()
    {
        string url = string.Format("file://{0}", "C:/Users/HP/Desktop/Audios/result.mp3"); 
        WWW www = new WWW(url);
        yield return www;

        audios.clip = www.GetAudioClip(false, false);
        audios.Play();
    }

    void RequestDelay()
    {
        chatBot.gameObject.SetActive(true);

        currentTime += Time.deltaTime;
        if(currentTime > 0 && currentTime < 0.5f)
        {
            chatBot.text = "오늘 하루 봇: 입력 중";
        }
        else if (currentTime > 0.5f && currentTime < 1f)
        {
            chatBot.text = "오늘 하루 봇: 입력 중.";
        }
        else if (currentTime > 1 && currentTime < 1.5f)
        {
            chatBot.text = "오늘 하루 봇: 입력 중..";
        }
        else if (currentTime > 1.5f && currentTime < 2f)
        {
            chatBot.text = "오늘 하루 봇: 입력 중...";
        }
        else if(currentTime > 2f)
        {
            currentTime = 0;
        }
    }
}