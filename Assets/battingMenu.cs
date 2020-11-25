using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void selectedBatType(int n)
    {
        gameBoard.selectedBatType = n;
    }
}
