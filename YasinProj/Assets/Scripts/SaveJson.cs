using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
[Serializable]
public class SaveJson : MonoBehaviour
{
    private string output;
    public class PreFabData
    {
        public GameObject Ships;
    }
    public GameObject Ships;
    [SerializeField] GameObject children;

    [Serializable]
    public class Ship_1
    {
        private string Name = "Ship_1";
        private int id = 1001;
    }
    //[Serializable]
    //public class Ship_2
    //{
    //    public string Name;
    //    public int id;
    //}
    //[Serializable]
    //public class Ship_3
    //{
    //    public string Name;
    //    public int id;
    //}

    public Ship_1 Myship_1 = new Ship_1();
    //public Ship_2 Myship_2 = new Ship_2();
    //public Ship_3 Myship_3 = new Ship_3();

    public void OutPutJson()
    {
        output = JsonUtility.ToJson(Myship_1);
        File.WriteAllText(Application.dataPath + "Assets/Ship_1.json", output);
        PlayerPrefs.SetString("Ship_1", output);
        PlayerPrefs.Save();
        //output = JsonUtility.ToJson(Myship_2);
        //output = JsonUtility.ToJson(Myship_3);

        //File.WriteAllText(Application.dataPath + "/Ship_2.json" , output);
        //File.WriteAllText(Application.dataPath + "/Ship_3.json" , output);

        //PlayerPrefs.SetString("Ship_2", output);
        //PlayerPrefs.SetString("Ship_3", output);

    }

    private string preFabPath = "Assets/Ship_1.json";
    private void Start()
    {

        var getJson = PlayerPrefs.GetString("Ship_1" , output);

        //output = File.ReadAllText(preFabPath);

        PreFabData ship_1 = JsonUtility.FromJson<PreFabData>(output);

        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();

        if (Ships != null)
        {

            Instantiate(Ships , canvas.transform);

        }




        //for (int i = 0; i < 4; i++)
        //{
        //    Ship_1 ship = JsonUtility.FromJson<Ship_1>(output);
        //    Ships[i] = Instantiate(Ships[i] , transform.position , Quaternion.identity);
        //}

    }
    //private void Start()
    //{
    //    GameData gameData = new GameData(new List<Player>()
    //    {
    //        new Player("Ship1" , 1 , "Red"),
    //        new Player("Ship2" , 2 , "Blue"),
    //        new Player("Ship3" , 3 , "Yellow"),
    //        new Player("Ship4" , 4 , "Pink"),
    //        new Player("Ship5" , 5 , "Green"),
    //    });

    //    json = JsonUtility.ToJson(gameData);
    //    File.WriteAllText(Application.dataPath + "/Ships.json", json);
    //    Debug.Log(json);
    //    PlayerPrefs.SetString("gamedata", json);
    //    PlayerPrefs.Save();

    //}

    //public void Onclick()
    //{
    //    var deb = PlayerPrefs.GetString("gamedata", json);
    //    Debug.Log(deb);
    //}

    //[Serializable]
    //public class Player
    //{
    //    public string Name;
    //    public int Age;
    //    public string color;
    //    public Player(string name, int age, string Color)
    //    {
    //        Name = name;
    //        Age = age;
    //        color = Color;
    //    }
    //}

    //[Serializable]
    //public class GameData
    //{
    //    public List<Player> PlayerList = new List<Player>();

    //    public GameData(List<Player> playerList)
    //    {
    //        this.PlayerList = playerList;
    //    }
    //}




    //[Serializable]
    //public class preFabsData
    //{
    //    public GameObject preFab;
    //}

    //public GameObject preFab;
    //private void Update()
    //{
    //    string preFabJson = File.ReadAllText(Application.dataPath + json);
    //    GameData prefabsData = JsonUtility.FromJson<GameData>(preFabJson);
    //    preFab = Instantiate(preFab, transform.position, Quaternion.identity);
    //}
}
