using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject splash;
    public float jumpForce;
    GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;
        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        GameObject splashGO = Instantiate(splash, transform.position + new Vector3(0f,-0.24f,0f), transform.rotation);
        splashGO.transform.SetParent(collision.gameObject.transform);
        StartCoroutine(Example(splashGO));

        if (materialName == "safeZone (Instance)")
        {
            Debug.Log("Artý puan");
        }
        else if(materialName == "dangerZone (Instance)")
        {
            gm.restart();
        }
        else if (materialName == "finalZone (Instance)")
        {
            Debug.Log("kazandýn");
        }

    }
    IEnumerator Example(GameObject go)
    {

        yield return new WaitForSeconds(1);
        Destroy(go);
    }
}
