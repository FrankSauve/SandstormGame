using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject heavyBandit;

    float floorLevel = -4.06f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(heavyBandit, new Vector3(4, floorLevel, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
