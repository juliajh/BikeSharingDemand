using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SH_ImageLoader : MonoBehaviour
{
    [SerializeField]
    private GameObject panelImageViewer;  // �̹��� ������ ����ϴ� Panel

    [SerializeField]
    private Image imagePreview;  // ������ ��Ÿ���� �̹��� ���

    [SerializeField]
    private Text textFileData;  // ���� �̸�, �ػ�, �뷮

    private float maxWidth = 1180;  // Image UI �ִ� ũ��
    private float maxHeight = 800;


    public void OnLoad(FileInfo file)
    {
        // �̹��� ������ ����ϴ� Panel Ȱ��ȭ
        panelImageViewer.SetActive(true);

        // ���Ϸκ��� Bytes �����͸� �ҷ��´�.
        byte[] byteTexture = File.ReadAllBytes(file.FullName);

        // byteTexture�� �ִ� byte �迭 ������ �������� Texture2D �̹��� ���� ������ ����
        Texture2D texture2D = new Texture2D(0, 0);
        if (byteTexture.Length > 0)
        {
            texture2D.LoadImage(byteTexture);
        }

        // �̹����� ����ϴ� Image UI�� ũ�� ����
        // ���� �ؽ�ó�� width ũ�Ⱑ Image UI�� �ִ� width ũ�⺸�� ũ��
        if (texture2D.width > maxWidth)
        {
            imagePreview.rectTransform.sizeDelta = new Vector2(maxWidth, maxWidth / texture2D.width * texture2D.height);
        }
        // ���� �ؽ�ó�� height ũ�Ⱑ Image UI�� �ִ� height ũ�⺸�� ũ��
        else if (texture2D.height > maxHeight)
        {
            imagePreview.rectTransform.sizeDelta = new Vector2(maxHeight / texture2D.height * texture2D.width, maxHeight);
        }
        // Texture2D�� Image UI �������� ���� �� Image UI ũ�⸦ Texture2D ũ��� ����
        else
        {
            imagePreview.rectTransform.sizeDelta = new Vector2(texture2D.width, texture2D.height);
        }


        // Texture2D -> Sprite ��ȯ
        Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));

        // imagePreview Image UI�� �������� �̹����� sprite�� ����
        imagePreview.sprite = sprite;

        // �̹��� ���� ���� ���
        textFileData.text = $"{file.Name} ({texture2D.width} * {texture2D.height}, {file.Length} Bytes)";
    }

    public void OffLoad()
    {
        // �̹��� ������ ����ϴ� Panel ��Ȱ��ȭ
        panelImageViewer.SetActive(false);
    }
}
