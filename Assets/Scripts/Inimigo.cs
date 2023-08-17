using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [SerializeField]
    private float velocidadeInimigo = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * velocidadeInimigo * Time.deltaTime);

        if (transform.position.y < -6.1f)
        {
            transform.position = new Vector3(Random.Range(-7, 7), 6.1f, transform.position.z);
        }
    }
}
