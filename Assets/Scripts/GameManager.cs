using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public static int goalCount;

    [SerializeField] public static int ballCount;
    public TMP_Text ballCountText;
    public TMP_Text goalCountText;
    public TMP_Text goalCountText2;


    // Start is called before the first frame update
    void Start()
    {
        goalCount = 0;
        ballCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        goalCountText.text = goalCount.ToString();
        goalCountText2.text = goalCount.ToString();

        ballCountText.text = (ballCount).ToString();
    }
}
