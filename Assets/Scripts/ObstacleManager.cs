using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class ObstacleObj 
{
    public GameObject prefab;
    public enum Position
    {
        Left, Mid, Right
    }
    public float row;
    public Position position;
    public float time;
    public float speed;
    public bool spawned;
}
public class ObstacleManager : MonoBehaviour
{
    public GameObject Track;
    AudioSource _audio;
    public float trackTime;
    public List<ObstacleObj> _obstacles2;
    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];
    private void Awake()
    {
        _audio = Track.GetComponent<AudioSource>();
        _audio.Play();
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }
    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        _obstacles2 = LevelEditor.levelEditorInstance.currentlevel.Array;
        Time.timeScale = 1;
    }
    public void ChangeArray(List<ObstacleObj> array)
    {
        _obstacles2 = array;
    }
    void MakeFreqBands()
    {
        int count = 0;
        for(int i=0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for(int j = 0; j < sampleCount; j++)
            {
                average += _samples[count]*(count+1);
                count++;
            }
            average /= count;
            _freqBand[i] = average * 10;

        }
    }
    private void Update()
    {
        trackTime = _audio.time;
        _audio.GetSpectrumData(_samples,0,FFTWindow.Blackman);
        MakeFreqBands();
        Spawn();
    }

    public void Spawn()
    {
        foreach (ObstacleObj obj in _obstacles2)
        {
            switch (obj.position)
            {
                case ObstacleObj.Position.Left:
                    obj.row = -5;
                    break;
                case ObstacleObj.Position.Mid:
                    obj.row = -3;
                    break;
                case ObstacleObj.Position.Right:
                    obj.row = -1;
                    break;
            }
            if (!obj.spawned && _audio.time > obj.time)
            {
                obj.spawned = true;
                GameObject x = Instantiate(obj.prefab, new Vector3(obj.row, 0, 30), Quaternion.identity);
                /*if (x.tag == "Obstacle")
                    x.GetComponent<Obstacle>().speed = obj.speed;
                else
                    x.GetComponent<AbilityStone>().speed = obj.speed;*/
            }
        }
    }
}

