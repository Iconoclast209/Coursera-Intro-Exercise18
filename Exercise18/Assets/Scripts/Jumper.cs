using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField]
    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        //Get Mouse Position
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;

        //Convert Mouse Position to desired character position
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Move character to that position
        character.transform.position = newPosition;
    }
}
