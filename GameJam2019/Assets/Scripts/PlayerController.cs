using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;

    public float speed = 10f;

    private void OnEnable() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb2d.position = rb2d.position + (Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb2d.position = rb2d.position + (Vector2.right * speed * Time.deltaTime);
        }
    }
}
