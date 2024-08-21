using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject preFab;
    [SerializeField] private GameObject preFabShips;
    [SerializeField] private GameObject preFabZones;

    private bool Close = false;


    
    public void destroy()
    {

        Destroy(preFab);

    }
    public void destroyShips()
    {
        Destroy(preFabShips);
    }
    public void destroyZones()
    {
        Destroy(preFabZones);
    }
    
}
