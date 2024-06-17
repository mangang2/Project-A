using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playingPlayer;
    public float Timer;
    public Text uiTextTimer;

    void SpawnPlayer()
    {
        playingPlayer = Instantiate(playerPrefab, Vector3.zero + new Vector3 (0, 1, 0) , Quaternion.identity);
        Timer = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        uiTextTimer.text = Timer.ToString("F1");                //소수점 1번째 자리까지만 ToS

        if(playingPlayer != null)
        Timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(playingPlayer == null)
            {
                SpawnPlayer();
            }
        }
        
    }
}
