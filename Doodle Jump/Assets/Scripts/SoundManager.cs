using UnityEngine;

public static class SoundManager {

    public static void PlaySound(){
        GameObject sound = new GameObject("Sound");
        AudioSource audio = sound.AddComponent<AudioSource>();
        audio.PlayOneShot(GameAssets.i.JumpSound);
    }
}
