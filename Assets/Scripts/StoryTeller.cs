using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTeller : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] Image storyImage;
    [SerializeField] StoryFlow storyFlows;
    StoryFlow flow;
    AudioClip speach;
    // Start is called before the first frame update
    void Start()
    {
        flow = storyFlows;
        storyText.text = flow.GetStoryText();
        speach = storyFlows.GetStorySpeach();
        GetComponent<AudioSource>().PlayOneShot(speach);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LeftFlow()
    {
        var nextFlows = flow.GetNextStoryFlow();
        flow = nextFlows[0];
        speach = nextFlows[0].GetStorySpeach();
        storyText.text = flow.GetStoryText();
        GetComponent<AudioSource>().PlayOneShot(speach);
    }
}
