using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour


{   
    CharacterController contr;
    public float speed = 12f;
    Transform playerBody;
    int score = 0;
    void Start()
    {
        contr = GetComponent<CharacterController>();
        playerBody = GetComponent<Transform>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        contr.Move(playerBody.forward*vertical*Time.deltaTime*speed);
        contr.Move(playerBody.right*horizontal*Time.deltaTime*speed);
        
        float mouseX = Input.GetAxis("Mouse X");
        playerBody.Rotate(0, mouseX, 0);
    }

    void OnControllerColliderHit(ControllerColliderHit col){
        if(col.gameObject.tag == "Pig"){
            Destroy(col.gameObject);
            print(score);
        }
        
    }
}
