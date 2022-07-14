using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public Transform ball;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y + 12.5f >= ball.position.y)
        {
            gm.GameScore(10);
            Destroy(this.gameObject);
        }
    }
}
