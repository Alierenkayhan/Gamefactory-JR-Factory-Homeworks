using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Core.Easing;
using Unity.VisualScripting;

public class PlayerManager : MonoBehaviour
{
    public Transform player;
 
    [SerializeField] private TMP_Text CounterText;
    [SerializeField] private GameObject playerobject;


    //**++++++++++++++++++++++++++++++++++
    [Range(0f, 1f)][SerializeField] private float DistanceFactor, Radius;

    //**++++++++++++++++++++++++++++++++++
    public bool moveByTouch, gameState;
    private Vector3 mouseStartPos, playerStartPos;
    public float playerSpeed, roadSpeed;
    private GameObject camera;
    public GameObject secondcamera;
    //**++++++++++++++++++++++++++++++++++
    [SerializeField] public Transform enemy;
    public bool attack;

    public GameObject lostscreen;

    public int counter;

    void Start()
    {
        player = transform;
        MakePlayer(10);
        camera.SetActive(true);
        secondcamera.SetActive(false);
    }

     void Update()
    {
        counter = GameObject.FindGameObjectsWithTag("Player").Length;
        CounterText.text = counter.ToString();
        lostscreen.SetActive(false);
        Debug.Log("number of player =" + counter);
    }

    

    private void FormatPlayer()
    {
        for (int i = 1; i < player.childCount; i++)
        {
            var x = DistanceFactor * Mathf.Sqrt(i) * Mathf.Cos(i * Radius);
            var z = DistanceFactor * Mathf.Sqrt(i) * Mathf.Sin(i * Radius);

            var NewPos = new Vector3(x, 0f, z);

            player.transform.GetChild(i).DOLocalMove(NewPos, 0.5f).SetEase(Ease.OutBack);
        }
    }

    private void MakePlayer(int number)
    {
        for (int i = 1; i < number; i++)
        {
            Instantiate(playerobject, transform.position,Quaternion.identity, transform);
            FormatPlayer();
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.Find("cat(Clone)");

        if (other.CompareTag("Gate"))
        {
            other.transform.parent.GetChild(0).GetComponent<BoxCollider>().enabled = false; // gate 1
            other.transform.parent.GetChild(1).GetComponent<BoxCollider>().enabled = false; // gate 2

            var gateManager = other.GetComponent<Gate>();

       

            if (gateManager.multiply)
            {
                
                MakePlayer(counter * gateManager.randomNumbercarpma);
                Debug.Log("carpma =" + (counter * gateManager.randomNumbercarpma));
            }
            else
            { 
                MakePlayer(counter + gateManager.randomNumbertoplama);
                Debug.Log("toplama =" + gateManager.randomNumbertoplama);
            }
        }
        if (other.CompareTag("Car"))
        {
            Destroy(go);
        }
        if (other.CompareTag("Finish"))
        {
            secondcamera.SetActive(true);
            camera.SetActive(false);
        }
    }
      private void OnTriggerStay(Collider other)
        {
            GameObject go = GameObject.Find("cat(Clone)");
            if (other.CompareTag("Enemy1"))
            {
                enemy = other.transform;
                attack = true;
                GameObject goforenemy = GameObject.FindGameObjectWithTag("EachEnemy1");
                GameObject goforenemyfinish = GameObject.FindGameObjectWithTag("Enemy1");
                GameObject goforallofthem = GameObject.Find("Player");

                if (player.childCount < enemy.childCount)
                {
                    Debug.Log("You lost");
                    Destroy(goforallofthem);
                    lostscreen.SetActive(true);
                }
                else if (player.childCount > enemy.childCount)
                {

                    for (int i = 0; i < player.childCount; i++)
                    {
                        if (enemy.childCount == 1)
                        {
                            Destroy(goforenemyfinish);
                            i = player.childCount;
                            attack = false;
                        }
                        else
                        {
                            Destroy(goforenemy);
                            Destroy(go);
                        }
                    }
                }
                if (player.childCount == enemy.childCount || player.childCount == 0)
                {
                    lostscreen.SetActive(true);
                }
            }
            if (other.CompareTag("Enemy2"))
            {
                enemy = other.transform;
                attack = true;
                GameObject goforenemy = GameObject.FindGameObjectWithTag("EachEnemy2");
                GameObject goforenemyfinish = GameObject.FindGameObjectWithTag("Enemy2");
                GameObject goforallofthem = GameObject.Find("Player");

                if (player.childCount < enemy.childCount)
                {
                    Debug.Log("You lost");
                    Destroy(goforallofthem);
                    lostscreen.SetActive(true);
                }
                else if (player.childCount > enemy.childCount)
                {

                    for (int i = 0; i < player.childCount; i++)
                    {
                        if (enemy.childCount == 1)
                        {
                            Destroy(goforenemyfinish);
                            i = player.childCount;
                            attack = false;
                        }
                        else
                        {
                            Destroy(goforenemy);
                            Destroy(go);
                        }
                    }
                }
                if (player.childCount == enemy.childCount || player.childCount == 0)
                {
                    lostscreen.SetActive(true);
                }
            }
            if (other.CompareTag("Enemy3"))
            {
                enemy = other.transform;
                attack = true;
                GameObject goforenemy = GameObject.FindGameObjectWithTag("EachEnemy3");
                GameObject goforenemyfinish = GameObject.FindGameObjectWithTag("Enemy3");
                GameObject goforallofthem = GameObject.Find("Player");

                if (player.childCount < enemy.childCount)
                {
                    Debug.Log("You lost");
                    Destroy(goforallofthem);
                    lostscreen.SetActive(true);
                }
                else if (player.childCount > enemy.childCount)
                {

                    for (int i = 0; i < player.childCount; i++)
                    {
                        if (enemy.childCount == 1)
                        {
                            Destroy(goforenemyfinish);
                            i = player.childCount;
                            attack = false;
                        }
                        else
                        {
                            Destroy(goforenemy);
                            Destroy(go);
                        }
                    }
                }
                if (player.childCount == enemy.childCount || player.childCount == 0)
                {
                    lostscreen.SetActive(true);
                }
            }
            if (other.CompareTag("Enemy4"))
            {
                enemy = other.transform;
                attack = true;
                GameObject goforenemy = GameObject.FindGameObjectWithTag("EachEnemy4");
                GameObject goforenemyfinish = GameObject.FindGameObjectWithTag("Enemy4");
                GameObject goforallofthem = GameObject.Find("Player");

                if (player.childCount < enemy.childCount)
                {
                    Debug.Log("You lost");
                    Destroy(goforallofthem);
                    lostscreen.SetActive(true);
                }
                else if (player.childCount > enemy.childCount)
                {

                    for (int i = 0; i < player.childCount; i++)
                    {
                        if (enemy.childCount == 1)
                        {
                            Destroy(goforenemyfinish);
                            attack = false;
                             
                        }
                        else
                        {
                            Destroy(goforenemy);
                            Destroy(go);
                        }
                    }
                }
                if (player.childCount == enemy.childCount || player.childCount == 0)
                {
                    lostscreen.SetActive(true);
                }
            }
            if (other.CompareTag("Car"))
            {
                Destroy(go);
            }
        }
    }
