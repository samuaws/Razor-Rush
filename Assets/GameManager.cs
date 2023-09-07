using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    public GameObject explosionPrefab;
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;
    public List<GameObject> obsticals;
    public bool bladesOut;
    public GameObject gameLostUI;
    public GameObject blades;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        bladesOut = blades.activeSelf;
    }
    private void Update()
    {
        scoreText.text = "Score : " + score;
        scoreText2.text = "Score : " + score;
    }
    public void InvertBlades()
    {
        blades.SetActive(!blades.activeSelf);
        bladesOut = blades.activeSelf;
        //rightBlade.SetActive(bladesOut);
        //lefttBlade.SetActive(bladesOut);
    }
    public void GameLost()
    {
        gameLostUI.SetActive(true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
