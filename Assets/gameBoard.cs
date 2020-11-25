using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public static string selectedBowlType1;
    public static int selectedBowlType2;
    public static int selectedBatType;

    public GameObject ball;

    public void bowl()
    {
        Vector3 pos = new Vector3(-1.11f, -5.28f, 0);
        Instantiate(ball, pos, Quaternion.identity);
    }
}
