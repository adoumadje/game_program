using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("Menu",LoadSceneMode.Single);
        }
    }
}
