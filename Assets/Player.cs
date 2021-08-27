using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Player : MonoBehaviour
{
    private PlayerControls controls;
    private Vector2 move;

    private Transform t;

    void Awake()
    {
        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += _ => move = Vector2.zero;

        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void UpdateFixed(){
        t.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime);
    }

}
