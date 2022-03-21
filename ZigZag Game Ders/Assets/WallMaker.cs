using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaker : MonoBehaviour
{
    public Transform wallPrefabs;
    public Transform lastWall;
    float posToAdd = 0.707f;
    Vector3 lastPos;
    Transform player;
    Camera camera;

    void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
        camera = Camera.main;
        lastPos = lastWall.position;
        InvokeRepeating("CreateWall", 0, 0.1f);
    }

    void CreateWall() {
        float distance = Vector3.Distance(player.position,lastPos);
        if(distance > camera.orthographicSize*2) return;
        Vector3 newPos = Vector3.zero;
        int rand = Random.Range(0,11);
        if(rand <= 5) {
            newPos = new Vector3(lastPos.x - posToAdd, lastPos.y, lastPos.z + posToAdd);
        } else {
            newPos = new Vector3(lastPos.x + posToAdd, lastPos.y, lastPos.z + posToAdd);
        }

        var newBlock = Instantiate(wallPrefabs,newPos,Quaternion.Euler(0,45,0),transform);
        lastPos = newBlock.position;
    }
}
