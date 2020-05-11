using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioRandPlayer : MonoBehaviour {

	public float 周期 = 0;


	public bool 随机浮动 = false;
	public float 浮动倍率 = 1f;

	public Text 文本_开始;
	public Text 文本_计时;
	public GameObject 周期slider;

	float time = 0f;
	float timer = 0f;
	bool start = false;

	private void Update()
	{
		if (start)
		{
			计时();

			if(timer >= (随机浮动?周期*浮动倍率:周期))
			{
				播放();
				timer -= 周期;
			}
		}
	}
	
	public void 当周期变化(float value)
	{
		周期 = value;
	}
	public void 随机浮动开关(bool value)
	{
		随机浮动 = value;
	}
	public void 随机浮动数值(float value)
	{
		浮动倍率 = value;
	}
	public void Set周期Slider(bool value)
	{
		周期slider.SetActive(value);
	}
	public void 开始按钮()
	{
		switch (start)
		{
			case false:
				开始();
				break;
			case true:
				停止();
				break;
		}
	}
	void 开始()
	{
		start = true;
		文本_开始.text = "停止";
		计时(true);
	}
	void 停止()
	{
		start = false;
		文本_开始.text = "开始";
	}

	void 计时(bool start = false)
	{
		if (start)
		{
			time = 0;
		}
		else
		{
			time += Time.deltaTime;
			timer += Time.deltaTime;
			文本_计时.text = "运行时间 " + time;
		}

	}




	void 播放()
	{

	}
}
