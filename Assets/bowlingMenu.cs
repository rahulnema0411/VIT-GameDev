using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bowlingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Text BowlText;

    string selectedBowltext = "";

    public void setBowl(int type)
    {
        if (type == 1)
        {
            selectedBowltext += "Fast ";
            gameBoard.selectedBowlType1 = "fast";
        }
        else
        {
            selectedBowltext += "Spin ";
            gameBoard.selectedBowlType1 = "spin";
        }
    }

    public void setBowlType(int n)
    {
        selectedBowltext += n;
        BowlText.text = selectedBowltext;
        gameBoard.selectedBowlType2 = n;
    }
}