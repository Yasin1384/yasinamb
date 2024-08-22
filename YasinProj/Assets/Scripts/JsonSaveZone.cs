using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonSaveZone : MonoBehaviour
{
    private string preFabPath = "Assets//Zones.json";
    private string OutPutZone;
    [SerializeField] private List<GameObject> parent;

    public class PreFabData
    {
        public GameObject Zones;
    }

    public List<GameObject> Zones;

    [Serializable]
    public class Zone_1
    {
        private string Name = "Zone_1";
        private int Id = 1001;
    }
    public class Zone_2
    {
        private string Name = "Zone_2";
        private int Id = 1002;
    }
    public class Zone_3
    {
        private string Name = "Zone_3";
        private int Id = 1003;
    }
    public class Zone_4
    {
        private string Name = "Zone_4";
        private int Id = 1004;
    }
    public class Zone_5
    {
        private string Name = "Zone_5";
        private int Id = 1005;
    }

    public Zone_1 Myzone_1 = new Zone_1();
    public Zone_2 Myzone_2 = new Zone_2();
    public Zone_3 Myzone_3 = new Zone_3();
    public Zone_4 Myzone_4 = new Zone_4();
    public Zone_5 Myzone_5 = new Zone_5();

    public void OutPutJsonZone()
    {
        OutPutZone = JsonUtility.ToJson(Myzone_1);
        PlayerPrefs.SetString("Zone_1", OutPutZone);

        OutPutZone = JsonUtility.ToJson(Myzone_2);
        PlayerPrefs.SetString("Zone_2", OutPutZone);

        OutPutZone = JsonUtility.ToJson(Myzone_3);
        PlayerPrefs.SetString("Zone_3", OutPutZone);

        OutPutZone = JsonUtility.ToJson(Myzone_4);
        PlayerPrefs.SetString("Zone_4", OutPutZone);

        OutPutZone = JsonUtility.ToJson(Myzone_5);
        PlayerPrefs.SetString("Zone_5", OutPutZone);

        PlayerPrefs.Save();


    }

    private void Start()
    {
        
        var Zone1 = PlayerPrefs.GetString("Zone_1", OutPutZone);
        var Zone2 = PlayerPrefs.GetString("Zone_2", OutPutZone);
        var Zone3 = PlayerPrefs.GetString("Zone_3", OutPutZone);
        var Zone4 = PlayerPrefs.GetString("Zone_4", OutPutZone);
        var Zone5 = PlayerPrefs.GetString("Zone_5", OutPutZone);


        PreFabData zone_1 = JsonUtility.FromJson<PreFabData>(OutPutZone);
        for (int i = 0; i < 6; i++)
        {
            if (Zones[i] != null)
            {
                Instantiate(Zones[i], parent[i].transform);
            }

        }

    }
}
