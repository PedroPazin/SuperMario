using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    PlayerDeath playerDeath;

    // Start is called before the first frame update
    void Start()
    {
        playerDeath = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {playerDeath.pontos.ToString()}";
    }
}
