using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class GameManager : MonoBehaviour
{

    //variables

    public GameObject circle;

    public Vector2 location = new Vector2(0, -9);

    public int score;

    public TextMeshProUGUI text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;

       


    }

    public void SpawnCircle()
    {
        Instantiate(circle, location, circle.transform.rotation);
    }


   
}
