using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class NextVButton : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject toast, objective, statement1, statement2, statement3, statement4, statement5, education, educationCanvas, project, skill, achievement,
		interest, declaration, statement6;
	string currentScene = "ObjectiveScene";
	void Start()
	{
		GameObject vb = GameObject.Find("SceneChangeVButton");
		vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		education.SetActive(false);
		educationCanvas.SetActive(false);
		toast.SetActive(false);
		statement2.SetActive(false);
		statement3.SetActive(false);
		statement4.SetActive(false);
		statement5.SetActive(false);
		statement6.SetActive(false);
		education.SetActive(false);
		educationCanvas.SetActive(false);
		project.SetActive(false);
		skill.SetActive(false);
		achievement.SetActive(false);
		interest.SetActive(false);
		declaration.SetActive(false);
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
		Debug.Log("Entered");
		if(currentScene == "ObjectiveScene")
		{
			objective.SetActive(false);
			statement1.SetActive(false);
			education.SetActive(true);
			educationCanvas.SetActive(true);
			currentScene = "EducationScene";
		}else if(currentScene == "EducationScene")
		{
			education.SetActive(false);
			educationCanvas.SetActive(false);
			skill.SetActive(true);
			statement2.SetActive(true);
			currentScene = "SkillsScene";
		}else if(currentScene == "SkillsScene")
		{
			skill.SetActive(false);
			statement2.SetActive(false);
			project.SetActive(true);
			statement3.SetActive(true);
			currentScene = "ProjectsScene";
		}else if(currentScene == "ProjectsScene")
		{
			project.SetActive(false);
			statement3.SetActive(false);
			achievement.SetActive(true);
			statement4.SetActive(true);
			currentScene = "AchievementScene";
		}else if(currentScene == "AchievementScene")
		{
			achievement.SetActive(false);
			statement4.SetActive(false);
			interest.SetActive(true);
			statement5.SetActive(true);
			currentScene = "InterestsScene";
		}else if(currentScene == "InterestsScene")
		{
			interest.SetActive(false);
			statement5.SetActive(false);
			declaration.SetActive(true);
			statement6.SetActive(true);
			currentScene = "FinalScene";
		}else
		{
			toast.SetActive(true);
		}
    }
	
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
	}
}
