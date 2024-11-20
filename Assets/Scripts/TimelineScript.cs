using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineScript : MonoBehaviour
{
    public PlayableDirector timeline;

    private void Start()
    {
        timeline.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TriggerTag"))
        {
            timeline.Play();
            Debug.Log("Timeline is playing!");
        }

    }
}
