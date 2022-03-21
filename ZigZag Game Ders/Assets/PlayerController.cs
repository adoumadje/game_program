using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    bool isLookingRight = true;

    int score, hscore;
    public Text scoreText, hscoreText;
    public ParticleSystem effectPrefab;
    GameManager gameManager;
    Animator animator;
    public Transform rayOrigin;

    void Start()
    {
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager = FindObjectOfType<GameManager>();
        animator = GetComponent<Animator>();
        LoadHScore();
    }

    private void LoadHScore() {
        hscore = PlayerPrefs.GetInt("hscore",0);
        hscoreText.text = hscore.ToString();
    }

    void Update()
    {
        if(!gameManager.GameStarted) return;
        animator.SetTrigger("GameStarted");
        // transform.position += transform.forward *Time.deltaTime*moveSpeed;
        transform.Translate(new Vector3(0,0,1)*Time.deltaTime*moveSpeed);
        if(Input.GetKeyDown(KeyCode.Space)){
            Turn();
        }
        CheckFalling();
    }

    private void CheckFalling() {
        if(!Physics.Raycast(rayOrigin.position, new Vector3(0,-1,0))) {
            animator.SetTrigger("Falling");
            gameManager.RestartGame();
        }
    }

    private void Turn() {
        if(isLookingRight){
            transform.Rotate(new Vector3(0,-90,0));
        } else{
            transform.Rotate(new Vector3(0,90,0));
        }
        isLookingRight = !isLookingRight;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Crystal") {
            MakeScore();
            var effect = Instantiate(effectPrefab);
            effect.transform.position = other.transform.position;
            Destroy(effect,1.0f);
            Destroy(other.gameObject);
        }
    }

    private void MakeScore() {
        score++;
        scoreText.text = score.ToString();
        if(score > hscore) {
            hscore = score;
            hscoreText.text = hscore.ToString();
            PlayerPrefs.SetInt("hscore",hscore);
        }
    }
}
