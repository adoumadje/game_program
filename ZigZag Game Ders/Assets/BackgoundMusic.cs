using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgoundMusic : MonoBehaviour
{
    static BackgoundMusic instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(instance);
    }
}
