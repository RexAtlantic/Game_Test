using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collision : MonoBehaviour
{

    public GameObject cube;

    private Rigidbody2D rb;

    public GameManager gm;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.SpawnCircle();

        gm.score++;

        Destroy(collision.gameObject);

     
    }
}
