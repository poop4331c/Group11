//Adds a new entry in the score table

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToScoreTable : MonoBehaviour
{
    public void AddHighscoreEntry(int score, string name)
    {
        //Create HighscoreEntry
        HighscoreEntry highscoreEntry = new HighscoreEntry { score = score, name = name };

        //Load saved Highscores
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

        //Add new entry
        highscores.highscoreEntryList.Add(highscoreEntry);

        //Sorts the list before saving
        for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
            {
                if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscores.highscoreEntryList[i];
                    highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
                    highscores.highscoreEntryList[j] = tmp;
                }
            }
        }

        //To keep it to only ten entries
        highscores.highscoreEntryList.RemoveAt(10);

        //Save updated Highscores
        string json = JsonUtility.ToJson(highscores);
        PlayerPrefs.SetString("highscoreTable", json);
        PlayerPrefs.Save();
    }

    public class Highscores
    {
        public List<HighscoreEntry> highscoreEntryList;
    }

    /* Represents a sigle Highscore entry*/
    [System.Serializable]
    public class HighscoreEntry
    {
        public int score;
        public string name;
    }
}
