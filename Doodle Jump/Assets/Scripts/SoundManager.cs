using UnityEngine;

public static class SoundManager {

    public enum Sound{
        death,
        menu,
        win
    }

    public static void PlaySound(Sound sound){
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audio = soundGameObject.AddComponent<AudioSource>();
        audio.PlayOneShot(GetAudioClip(sound));
    }

    static AudioClip GetAudioClip(Sound sound){
        foreach(GameAssets.SoundAudioClip soundAudioClip in GameAssets.i.sounds){
            if(soundAudioClip.sound == sound) return soundAudioClip.audioClip;
        }
        return null;
    }
}
