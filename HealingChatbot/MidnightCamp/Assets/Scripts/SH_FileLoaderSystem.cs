//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SH_FileLoaderSystem : MonoBehaviour
//{
//    // 확장자별 파일 처리 (Load & Play)
//    private SH_FileLoader fileloader; // 문서, 일반 파일
//    private SH_ImageLoader imageLoader; // 이미지 파일


//    private void Awake()
//    {
//        fileloader = GetComponent<SH_FileLoader>();
//        imageLoader = GetComponent<SH_ImageLoader>();
//    }

//    public void LoadFile(FileInfo file)
//    {
//        offAllPanel();

//        // 선택한 파일이 문서 파일일 경우 문서 프로그램 실행
//        if (file.FullName.Contains(".pdf") || file.FullName.Contains(".xlsx") || file.FullName.Contains(".doc") || file.FullName.Contains(".pptx") || file.FullName.Contains(".hwp") || file.FullName.Contains(".txt"))
//        {
//            fileloader.OnLoad(file);
//        }
//        // 선택한 파일이 이미지 파일일 경우 화면에 이미지 출력
//        else if (file.FullName.Contains(".jpg") || file.FullName.Contains(".png"))
//        {
//            imageLoader.OnLoad(file);
//        }
//        // 나머지 모든 확장자는 문서와 동일하게 파일 정보 출력
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
