using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target_Triger : MonoBehaviour
{
    // Start is called before the first frame update
    public float uiDelay = 3f;
    public Collider marble;
    public Timing_control timing_control;
    public Coin_Control coin_control;
    public ParticleSystem completeParticleSystem;
    public ParticleSystem completeParticleSystem2;
    public GameObject Panel;

    AudioSource m_AudioSource;
    void Awake()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other == marble)
        {
            completeParticleSystem.Play();
            completeParticleSystem2.Play();
            timing_control.GoalReached(uiDelay);
            Panel.SetActive(true);

        }
    }
}
