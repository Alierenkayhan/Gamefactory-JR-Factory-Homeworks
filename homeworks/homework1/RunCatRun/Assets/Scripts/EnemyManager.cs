using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private TMP_Text CounterText;
    [SerializeField] private GameObject playerobject;

    [Range(0f, 1f)][SerializeField] private float DistanceFactor, Radius;


    void Start()
    {
        for (int i = 0; i < Random.Range(10,20); i++)
        {
            Instantiate(playerobject, transform.position, new Quaternion(0f,180f,0f,1f), transform);
        }
         
        FormatPlayer();

       
    }
 
    private void FormatPlayer()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            var x = DistanceFactor * Mathf.Sqrt(i) * Mathf.Cos(i * Radius);
            var z = DistanceFactor * Mathf.Sqrt(i) * Mathf.Sin(i * Radius);

            var NewPos = new Vector3(x, -0.6f, z);

            transform.transform.GetChild(i).localPosition = NewPos;
        }
    }
    void Update()
    {
        CounterText.text = (transform.childCount).ToString();
    }

}
