using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionController : MonoBehaviour
{

    public int currentSession = 1;

    public static SessionController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            Debug.Log("Session controller created");
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
