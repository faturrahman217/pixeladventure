using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chichken : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public bool moveRight;
    public float move = 0;
    public Rigidbody2D rb;
    public bool m_FacingRight = false;

    // Update is called once per frame
    void Update()
    {
        if (move > 0 && move <= 151)
        {
            move++;
            if (move == 151)
            {
                move = 0;
            }
        }
        else if (move <= 0 && move >= -151)
        {
            move--;
            if (move == -151)
            {
                move = 1;
            }
        }
        int movement = move > 0 ? 3 : -3;

        if (movement < 0 && !m_FacingRight)
        {

            Flip();

        }
        else if (movement > 0 && m_FacingRight)
        {

            Flip();

        }
        rb.velocity = new Vector2(movement, rb.velocity.y);
    }
    private void Flip()
    {

        m_FacingRight = m_FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
