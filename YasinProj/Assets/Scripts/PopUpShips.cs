using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PopUpShips : MonoBehaviour
{

    [SerializeField] private GameObject[] preFabShips;

    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject[] ships;

    //[SerializeField] GameObject[] parents;
    //[SerializeField] Color[] colors;
    [SerializeField] GameObject[] children;



    //public void ClickSpawn()
    //{
    //    for (int i = 0; i <6; i++)
    //    {
    //        GameObject childGameObject = parents[i].transform.GetChild(0).gameObject;
    //        children[i] = childGameObject.GetComponent<Image>();
    //        children[i].color = colors[i];
    //    }

    //}

    public void Spawn()
    {
       
    

        // Get a reference to the child GameObject


        // Set the parent of the child GameObject to the parent GameObject


        for (int i = 0; i < preFabShips.Length; i++)
        {
            //ships[i] = GameObject.Find("Ship1");
            //preFabShips[i] = GameObject.Find("image1");
            //ships[i].transform.SetParent(preFabShips[i].transform, false);
            //children[i] = GameObject.Find("gameobject").GetComponent<GameObject>();
            //children[i] = Instantiate(preFabShips[i], ships[i].transform.position, Quaternion.identity, ships[i].transform);
            //children[i].transform.localPosition = Vector3.zero;
            //children[i].transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
