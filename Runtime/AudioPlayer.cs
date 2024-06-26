using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoJin
{
    public class AudioPlayer : MonoBehaviour
    {
        private void OnEnable()
        {
            StartCoroutine(nameof(PlayAudioAndDestroy));
        }



        private IEnumerator PlayAudioAndDestroy()
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            float time = audioSource.clip.length;



            audioSource.Play();
            yield return new WaitWhile(() =>
            {
                return audioSource.isPlaying || Mathf.Abs(time - audioSource.time) >= 0.01f;
            });
            Destroy(gameObject);
        }
    }
}
