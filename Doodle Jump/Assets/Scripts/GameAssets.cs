using UnityEngine;

public class GameAssets : MonoBehaviour
{
    public static GameAssets _i;

    public static GameAssets i{
        get{
            if (_i == null) _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }

    public SoundAudioClip[] sounds;

    [System.Serializable]
    public class SoundAudioClip{
        public AudioClip audioClip;
        public SoundManager.Sound sound;
    }
}
