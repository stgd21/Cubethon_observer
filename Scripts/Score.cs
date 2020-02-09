using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public delegate void Milestone(float distance);
    public static event Milestone OnMilestone;

    //Reference player position and text to update
    public Transform player;
    public Text scoreText;
    public float milestoneIncrement = 150f;

    //Update called once per frame
    void Update()
    {
        //Update text with player position whole number
        scoreText.text = player.position.z.ToString("0");

        if (player.position.z >= milestoneIncrement)
        {
            OnMilestone(milestoneIncrement);
            milestoneIncrement *= 3;
        }
    }
}