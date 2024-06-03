using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInformationOverlay : MonoBehaviour
{
    public bool isInfoActive = false;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void showInfoOverlay()
    {

        gameObject.SetActive(!isInfoActive);
    }


    public void hideInfoOverlay()
    {

        gameObject.SetActive(false);


    }


}
