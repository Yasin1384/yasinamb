using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup_Setting : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] private Button openShipsButton;
    [SerializeField] private Button openZonesButton;

    
    [SerializeField] private GameObject popupShipsPrefabs;
    [SerializeField] private GameObject popupZonesPrefabs;

    private void Start()
    {
        closeButton.onClick.AddListener(OnCloseButtonClicked);
        openShipsButton.onClick.AddListener(OnOpenShipsButtonClicked);
        openZonesButton.onClick.AddListener(OnOpenzoneButtonClicked);

    }

    private void OnCloseButtonClicked() 
    {

        Destroy(this.gameObject);
    }

    private void OnOpenShipsButtonClicked()
    {
        Canvas canvas = this.gameObject.GetComponentInParent<Canvas>();
        Instantiate(popupShipsPrefabs, canvas.transform);
    }
    private void OnOpenzoneButtonClicked()
    {
        Canvas canvas = this.gameObject.GetComponentInParent<Canvas>();
        Instantiate(popupZonesPrefabs, canvas.transform);
    }


}
