using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Header : MonoBehaviour
{
    [SerializeField] private Button buttonHeader;
    [SerializeField] private GameObject popupSetting;


    private void Start()
    {
        buttonHeader.onClick.AddListener(OnclickButtonHeader);
    }
    private void OnclickButtonHeader()
    {
        Canvas canvas = this.gameObject.GetComponentInParent<Canvas>();
        Instantiate(popupSetting, canvas.transform);
    }
}
