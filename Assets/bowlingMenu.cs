using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bowlingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Text BowlText;

    private string selectedBowltext = "";

    public void setBowl(int type)
    {
        if (type == 1)
        {
            selectedBowltext += "fast ";
        }
        else
        {
            selectedBowltext += "spin ";
        }
    }

    public void setBowlType(int n)
    {
        selectedBowltext += n;

        //BowlText.enabled = true;
        BowlText.text = selectedBowltext;
    }
}