using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerRightRacket : Racket
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if(ball.velocity.x > 0.0f)
        {
            if(ball.position.y > _rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
            else if(ball.position.y < _rigidbody.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else if(ball.velocity.x < 0.0f)
        {
            if(_rigidbody.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
            else if(_rigidbody.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
