using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.Rendering.Universal;

public class PlayerController : MonoBehaviour
{
    public TMP_Text debugText;
    public TMP_Text coinText;






    public string playerName = "Alien";
    [Range(1,555)]
    [SerializeField]float moveSpeed = 5.5f;

    float jumpPower = 10.5f;
    int totalCoins = 5;
    int coins;

    bool isGrounded = true;

    Rigidbody2D rb;
    SpriteRenderer sprites;
    Vector2 move;

    int count = 5;
    int health = 100;
    int energy = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for(int i=1; i <= count; i++)
        {
            if (i% 2 == 0)
            {
                print($"Round: {i}");
            }
        }

        while (health > 0)
        {
            health -= 30;
            Debug.Log("Hit! Health: " + health);

        }

        while(energy >0)
        {
            Debug.Log("while round");
            energy--;
        }
        do
        {
            Debug.Log("do-while round");
            energy--;
        } while (energy > 0);
        print(energy);




        rb = GetComponent<Rigidbody2D>();
        sprites = GetComponent<SpriteRenderer>();
        Debug.Log("Somchai");
        Debug.Log($"Player: {playerName}");
    }

    // Update is called once per frame
    void Update()
    {
        debugText.text = $"Position: {transform.position.x}, {transform.position.y}";



        move = InputSystem.actions.FindAction("Move").ReadValue<Vector2>();
        if (InputSystem.actions.FindAction("Jump").WasPressedThisFrame()&&isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
        
        if (move.x > 0.1f)
        {
            sprites.flipX = false;
        }
        else if (move.x < -0.1f)
        {
            sprites.flipX = true; ;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(move.x * moveSpeed, rb.linearVelocity. y);
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal.y > 0.5f)
        {
            isGrounded = true;
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coins += 1;
            Debug.Log($"Coin: {coins}");

            if (coins >= totalCoins) 
            {
                coinText.text = "All Coins Collected";
            }
            else
            {
                coinText.text = $"Coin: {coins} / {totalCoins}";
            }
            Destroy(other.gameObject);
        }
    }
}