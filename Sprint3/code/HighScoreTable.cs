//Used skeleton code from Code Monkey

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScoreTable : MonoBehaviour
{
    public Transform entryContainer;
    public Transform entryTemplate;
    public List<HighscoreEntry> highscoreEntryList;
    public List<Transform> highscoreEntryTransformList;  

    public void Awake()
    {
        entryContainer = transform.Find("HSEntryContainer");
        entryTemplate = entryContainer.Find("HSTemplate");

        //Hide default template
        entryTemplate.gameObject.SetActive(false);
        
        //When there isn't any data stored, default values are loaded
        if (!PlayerPrefs.HasKey("highscoreTable"))
        {
            LoadDefaultIfEmpty();
        }
        
        string jsonString = PlayerPrefs.GetString("highscoreTable");
        Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
     
        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
        {
            CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }

    }

    //Receives Highscore Entry object
    public void CreateHighScoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
            float templateHeight = 35f;

            Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
            entryTransform.gameObject.SetActive(true);


            int rank = transformList.Count + 1;
            string rankString;
            if (rank > 3)
            {
                rankString = rank.ToString() + "TH";
            }
            else if (rank == 1)
            {
                rankString = rank.ToString() + "ST";
            }
            else if (rank == 2)
            {
                rankString = rank.ToString() + "ND";
            }
            else
            {
                rankString = rank.ToString() + "RD";
            }
            entryTransform.Find("posText").GetComponent<Text>().text = rankString;

            int score = highscoreEntry.score;
            entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

            string name = highscoreEntry.name;
            entryTransform.Find("nameText").GetComponent<Text>().text = name;

            entryTransform.Find("background").gameObject.SetActive(rank % 2 == 1);

            transformList.Add(entryTransform);
    }

    public void LoadDefaultIfEmpty()
    {
        //This is how we put in values
        highscoreEntryList = new List<HighscoreEntry>()
              {
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"},
                  new HighscoreEntry { score = 00000, name = "AAA"}
              };

        Highscores defaultHighscores = new Highscores { highscoreEntryList = highscoreEntryList };
        string json = JsonUtility.ToJson(defaultHighscores);
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
