using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;
    private int Score = 0;
    public Text Txt_Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Txt_Score.text = "SCORE : 0";
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("Gameover");
        }
        if (other.gameObject.tag == "score")
        {
            Score += 1;
            Txt_Score.text = "SCORE : " + Score;
        }
    }
}
