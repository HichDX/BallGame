using UnityEngine;
using UnityEngine.Audio;

namespace HichDX
{
    public class PauseMenu : MonoBehaviour
    {
        public AudioMixerGroup Mixer;
        
        public void Pause()
        {
            Time.timeScale = 0;
        }

        public void Proceed()
        {
            Time.timeScale = 1;
        }

        public void ToogleMusic(bool enabled)
        {
            if (enabled)
            {
                Mixer.audioMixer.SetFloat("MusicVolume", 0);
            }

            else
            {
                Mixer.audioMixer.SetFloat("MusicVolume", -80);
            }
        }

    }
}
