using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public Text strokeText;
    public int strokesAmount;
    public Text keepGoing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        strokeText.text = strokesAmount + "Clicks";

    }

    public void IncreaseStrokesAmount()
    {
        strokesAmount += 1;
       
    }
}
