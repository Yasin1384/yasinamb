using Palmmedia.ReportGenerator.Core.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;




public class JsonDataLoad : MonoBehaviour
{


    //[Serializable]
    //private class ImageData
    //{
    //    public string src;
    //    public string dst;
    //}
    //public GameObject[] Prefab;

    //private List<ImageData> imageDatas;

    //private void Start()
    //{
    //    SaveImageAsJson();

    //    LoadImage();
    //}

    //private void SaveImageAsJson()
    //{
    //    imageDatas = new List<ImageData>();

    //    foreach (var image in Prefab)
    //    {
    //        imageDatas.Add(new ImageData()
    //        {
    //            src = AssetDatabase.GetAssetPath(image),
    //            dst = image.name
    //        });
    //    }

    //    string jsonData = JsonUtility.ToJson(imageDatas);
    //    File.WriteAllText(Application.persistentDataPath + "/Ships.json" , jsonData);
    //}
    //private void LoadImage()
    //{
    //    string jsonData = File.ReadAllText(Application.persistentDataPath + "/Ships.json");
    //    imageDatas = JsonUtility.FromJson<List<ImageData>>(jsonData);

    //    foreach (var imageInfo in imageDatas)
    //    {
    //        Sprite sprite = Resources.Load<Sprite>(imageInfo.src);
    //        Debug.Log("www");
    //    }
    //}
}
