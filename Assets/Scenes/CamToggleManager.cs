using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamToggleManager : MonoBehaviour
{
    public Camera[] cams;

    
    public void SelectCamera(Toggle send)
    {
        if (send.isOn)
        {
            if(send.tag == "TopView")
            {
                cams[0].enabled = true;
                cams[1].enabled = false;
            }
            else
            {
                cams[0].enabled = false;
                cams[1].enabled = true;
            }

        }


    }
    

}
