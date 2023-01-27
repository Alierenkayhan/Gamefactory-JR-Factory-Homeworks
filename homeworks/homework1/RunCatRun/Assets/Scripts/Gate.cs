using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    public TMP_Text GateNo;
    public int randomNumbercarpma;
    public int randomNumbertoplama;
    public int randomNumberForIslem;
    public bool multiply;


    void Start()
    {
        randomnumberandislem();
    }

    public void randomnumberandislem()
    {
      
        if (multiply)
        {
            randomNumbercarpma = Random.Range(1, 5);
            GateNo.text = "X" + randomNumbercarpma;
        }
        else
        {
            randomNumbertoplama = Random.Range(5, 20);
            GateNo.text = "+" + randomNumbertoplama.ToString();
        }

    }
}
