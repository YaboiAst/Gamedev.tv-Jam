using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    private Transform alvo;
   
    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, alvo.position, speed * Time.deltaTime);

    }
}
