//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SH_FileLoaderSystem : MonoBehaviour
//{
//    // Ȯ���ں� ���� ó�� (Load & Play)
//    private SH_FileLoader fileloader; // ����, �Ϲ� ����
//    private SH_ImageLoader imageLoader; // �̹��� ����


//    private void Awake()
//    {
//        fileloader = GetComponent<SH_FileLoader>();
//        imageLoader = GetComponent<SH_ImageLoader>();
//    }

//    public void LoadFile(FileInfo file)
//    {
//        offAllPanel();

//        // ������ ������ ���� ������ ��� ���� ���α׷� ����
//        if (file.FullName.Contains(".pdf") || file.FullName.Contains(".xlsx") || file.FullName.Contains(".doc") || file.FullName.Contains(".pptx") || file.FullName.Contains(".hwp") || file.FullName.Contains(".txt"))
//        {
//            fileloader.OnLoad(file);
//        }
//        // ������ ������ �̹��� ������ ��� ȭ�鿡 �̹��� ���
//        else if (file.FullName.Contains(".jpg") || file.FullName.Contains(".png"))
//        {
//            imageLoader.OnLoad(file);
//        }
//        // ������ ��� Ȯ���ڴ� ������ �����ϰ� ���� ���� ���
//        else
//        {
//            fileLoader.OnLoad(file);
//        }
//    }

//    private void OffAllPanel()
//    {
//        fileloader.OffLoad();
//        imageLoader.OffLoad();
//    }
//}
