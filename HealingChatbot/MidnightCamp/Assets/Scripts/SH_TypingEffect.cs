using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SH_TypingEffect : MonoBehaviour
{
    public Text tx;
    public Text tx2;
    public Text emotion;
    public Text subText;

    //public string m_title;
    public string m_title2;
    public string m_title3;
    public string m_title3_2;
    public string m_title4;
    public string m_title4_2;
    string faceResult;

    public bool before = false;
    public bool isPlay;
    public bool isGo;
    public bool isUpload;
    public bool loadComplete;

    public float loadingTime = 2;

    public Button play;
    public Button go; 
    public Button upload;

    public InputField sex;
    public InputField age;
    public InputField mbti;

    public Image loadingBar;
    public RawImage image;

    public SH_ScrollBar scroll;

    RectTransform textRect;
    RectTransform textRect2;
    RectTransform textRect_emotion;
    RectTransform imgRect;
    RectTransform buttonRect;

    public GameObject inputField;
    public GameObject button;
    public GameObject doona;


    void Start()
    {

        textRect = tx.GetComponent<RectTransform>();
        textRect2 = tx2.GetComponent<RectTransform>();
        textRect_emotion = emotion.GetComponent<RectTransform>();
        imgRect = image.GetComponent<RectTransform>();
        buttonRect = upload.GetComponent<RectTransform>();
        faceResult = SH_FileManager.face;  // 감정 분석 결과 string

        play.gameObject.SetActive(false);
        StartCoroutine(typing(m_title2, go));
    }

    private void Update()
    {
        //print("text : " + textRect.anchoredposition);
        //print("img : " + imgrect.anchoredposition);
        //print("btn : " + buttonrect.anchoredPosition);


        //if (isPlay)
        //{
        //    play.gameObject.SetActive(false);
        //    StartCoroutine(typing(m_title2, go));
        //    isPlay = false;
        //}
        if (isGo)
        {
            go.gameObject.SetActive(false);
            sex.gameObject.SetActive(false);
            age.gameObject.SetActive(false);
            mbti.gameObject.SetActive(false);
            StartCoroutine(typing(m_title3, upload));
            isGo = false;
        }
        if (isUpload)
        {
            upload.gameObject.SetActive(false);
            image.gameObject.SetActive(false);
            StartCoroutine(typing(m_title4, upload));
            isUpload = false;
        }
    }

    
    IEnumerator typing(string title, Button button)
    {
        // 텍스트 위치 지정
        tx.text = "";
        tx2.text = "";

        if (title == m_title2)
        {
            textRect.anchoredPosition = new Vector2(0, -262);
        }
        if (title == m_title3)
        {
            textRect.anchoredPosition = new Vector2(0, -176);
        }
        if (title == m_title4)
        {
            // 표정 분석 결과 text
            title = m_title4;
            textRect_emotion.anchoredPosition = new Vector2(0, -290);
            for (int i = 0; i < title.Length; i++)
            {
                emotion.text += title[i];
                yield return new WaitForSeconds(0.15f);
            }
            emotion.text += faceResult;  // 감정 분석 결과 

            title = m_title4_2;
            textRect.anchoredPosition = new Vector2(0, -400);
        }

        // 타자치는듯한 효과 타이핑
        for (int i = 0; i < title.Length; i++)
        {
            tx.text += title[i];
            yield return new WaitForSeconds(0.15f);
        }

        // 입력필드
        if (title == m_title2)
        {
            sex.gameObject.SetActive(true);
            age.gameObject.SetActive(true);
            mbti.gameObject.SetActive(true);
        }

        // 사진 upload
        if (title == m_title3)
        {
            title = m_title3_2;
            textRect2.anchoredPosition = new Vector2(0, -290);
            for (int i = 0; i < title.Length; i++)
            {
                tx2.text += title[i];
                yield return new WaitForSeconds(0.15f);
            }
            image.gameObject.SetActive(true);
        }

        // 로딩 UI
        if (title == m_title4_2)
        {
            loadingBar.gameObject.SetActive(true);
            subText.gameObject.SetActive(true);


            scroll.enabled = true;
        }
        // �ε� UI ���� �Ѿ�� ��ư Ȱ��ȭ
        else
        {
            yield return new WaitForSeconds(0.5f);
            button.gameObject.SetActive(true);
        }
        
    }
}
      