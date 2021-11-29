using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    private float speed;
    private int rotationSpeedX, rotationSpeedY, rotationSpeedZ;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1f, 2f);

        rotationSpeedX = Random.Range(20, 50);
        rotationSpeedY = Random.Range(20, 50);
        rotationSpeedZ = Random.Range(20, 50);

        transform.position = new Vector3(Random.Range(-1f, 1f), Random.Range(.5f, 1f), 7.5f);

        transform.rotation = Random.rotation;

        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed, Space.World);
        transform.Rotate(new Vector3(1 * (rotationSpeedX * Time.deltaTime), 1 * (rotationSpeedY * Time.deltaTime), 1 * (rotationSpeedZ * Time.deltaTime)));
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(.5f, .5f, .5f), 1 * Time.deltaTime);

        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
