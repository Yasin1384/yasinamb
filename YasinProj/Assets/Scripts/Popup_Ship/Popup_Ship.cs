using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Load json 
//desrialize json to instanc class
//Data Ship for instanc ship ui item prefab in content
public class Popup_Ship : MonoBehaviour
{
    private const string kGameDataConfig = "_GAME_DATA_CONFIG_";


    public string jsonDataString = "{\r\n  \"shipList\": [\r\n    {\r\n      \"name\": \"Ship_01\",\r\n      \"id\": 1001\r\n    },\r\n    {\r\n      \"name\": \"Ship_02\",\r\n      \"id\": 1002\r\n    },\r\n    {\r\n      \"name\": \"Ship_03\",\r\n      \"id\": 1003\r\n    },\r\n    {\r\n      \"name\": \"Ship_04\",\r\n      \"id\": 1004\r\n    },\r\n    {\r\n      \"name\": \"Ship_05\",\r\n      \"id\": 1005\r\n    },\r\n    {\r\n      \"name\": \"Ship_06\",\r\n      \"id\": 1006\r\n    },\r\n    {\r\n      \"name\": \"Ship_07\",\r\n      \"id\": 1007\r\n    },\r\n    {\r\n      \"name\": \"Ship_08\",\r\n      \"id\": 1008\r\n    },\r\n    {\r\n      \"name\": \"Ship_09\",\r\n      \"id\": 1009\r\n    },\r\n    {\r\n      \"name\": \"Ship_10\",\r\n      \"id\": 1010\r\n    }\r\n  ]\r\n}";

    //GameObject for Cild
    [SerializeField] private Transform contentTransform;

    //PopUpShips
    [SerializeField] private Button closePopupShipButton;
    [SerializeField] private GameObject popupShipPrefab;


    [SerializeField] private GameObject shipPrefab;

    public string debug;
    private void Start()
    {

/*        GameDataConfig gameDataConfig = new GameDataConfig(new List<Ship>()
        {
            new Ship("Ship_01", 1001),
            new Ship("Ship_02", 1002),
            new Ship("Ship_03", 1003),
            new Ship("Ship_04", 1004),
            new Ship("Ship_05", 1005)

        });*/

       // debug = JsonUtility.ToJson(gameDataConfig);

        //Save json ship
        CallJsonShips();

        //Button Close Popup_Ship
        closePopupShipButton.onClick.AddListener(OnClickCloseButton);

        //Load Ships & Load Data Json
        // var saveShip = PlayerPrefs.GetString(kGameDataConfig, shipToJson);
        GameDataConfig gameDataConfig = JsonUtility.FromJson<GameDataConfig>(jsonDataString);


        for (int i = 0; i < gameDataConfig.shipList.Count; i++)
        {
            GameObject gameObject =  Instantiate(shipPrefab, contentTransform);
        }

        

    }
    

    private void CallJsonShips()
    {

        PlayerPrefs.Save();
    }






























    //Button Destroy PopUp_Ship
    private void OnClickCloseButton()
    {
        Destroy(this.gameObject);
    }




}

[Serializable]
public class Ship
{
    public string name;
    public int id;

    public Ship(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}

[Serializable]
public class GameDataConfig
{
public List<Ship> shipList = new List<Ship>();

    public GameDataConfig(List<Ship> shipList)
    {
        this.shipList = shipList;
    }
}