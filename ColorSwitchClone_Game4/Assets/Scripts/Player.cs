using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public string color;

    public Color purple;
    public Color blue;
    public Color red;
    public Color yellow;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        setColor();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            //rb.velocity = Vector2.zero;
            //rb.AddForce(Vector2.up * jumpForce);

            rb.velocity = Vector2.up * jumpForce;
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.CompareTag("switcher"))
        {
            setColor();
            //collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            return;
        }

        if (!collision.CompareTag(color))
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}        
	}

    public void setColor()
	{
        int i = Random.Range(0, 4);

		switch (i)
		{
            case 0:
                color = "purple";
                sr.color = purple;
                break;
            
            case 1:
                color = "blue";
                sr.color = blue;
                break;

            case 2:
                color = "red";
                sr.color = red;
                break;

            case 3:
                color = "yellow";
                sr.color = yellow;
                break;
        }
	}
}
