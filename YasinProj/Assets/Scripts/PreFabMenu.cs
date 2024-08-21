using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreFabMenu : MonoBehaviour
{
    [SerializeField] private GameObject preFab;
    [SerializeField] private GameObject preFabShips;
    [SerializeField] private GameObject preFabHeader;
    [SerializeField] private GameObject preFabZones;


    private void Start()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Instantiate(preFabHeader , canvas.transform);
    }
    public void SpawnSetting()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Instantiate(preFab, canvas.transform);
    }

    public void SpawnShips()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Instantiate(preFabShips, canvas.transform);
    }
    public void SpawnZones()
    {
        Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        Instantiate (preFabZones, canvas.transform);
    }


}
