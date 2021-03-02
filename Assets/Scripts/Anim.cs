using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator anime;
    public ExampleStreaming exampleStreaming;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (exampleStreaming.flag == "greet")
        {
            anime.Play("female_greet");
        }
        if (exampleStreaming.flag == "happy")
        {
            anime.Play("female_emotion_happy");
        }

        if (exampleStreaming.flag == "yes")
        {
            anime.Play("female_say_yes");
        }

    }
}