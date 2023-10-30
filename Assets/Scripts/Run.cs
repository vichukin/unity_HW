using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float  jumpForse, moveInput;
    float speed = CoinCount.Speed*2;

    public Transform pos;

    public bool isGrounded = true;
    bool jumpb, facingRight = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;



    //SpriteRenderer SpriteRenderer;
    public int Coins = 0;
    public Text CoinText;
    public Transform GetPosition()
    {
        return pos;
    }
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //void FixedUpdate()
    //{

    //}

    void playAnimation()
    {
        if (moveInput != 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        playAnimation();
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }
    private void Update()
    {
        //playAnimation();    

        var Up = Input.GetAxis("Vertical");

        if (isGrounded == true)
        {
            //if (anim.GetInteger("Jump") == 0)
            //{

            //    anim.SetInteger("Jump", 4);

            //}
            extraJumps = extraJumpsValue;
            //Debug.Log();
        }


        if (Up > 0)
            Jump(Up);
        else if (Up == 0 && isGrounded == false)
        {

        }
            //anim.SetInteger("Jump", 0);
    }
    void Jump(float Up)
    {
        if (Up > 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForse;
            isGrounded = false;
            //anim.SetInteger("Jump", 1);
            //Debug.Log(anim.GetInteger("Jump"));
            //Debug.Log(isGrounded.ToString());
            //anim.SetInteger("Jump", 3);
        }
        else if (Up > 0 && extraJumps > 0)
        {
            //Debug.Log("ZOPA");
            //anim.SetInteger("Jump", 2);
            rb.velocity = Vector2.up * jumpForse;
            extraJumps--;
            //anim.SetInteger("Jump", 3);
        }
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Coin")
        {
            Coins++;
            Destroy(collision.gameObject);
            CoinText.text = "Coins: " + (CoinCount.Coins + Coins);
        }
    }
}
