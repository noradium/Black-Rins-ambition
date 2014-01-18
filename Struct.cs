using System;
using System.Collections;

using Sce.PlayStation.HighLevel.GameEngine2D;

namespace ShootingApp
{
	public struct ScreenSize
   	{
        public int Width;
        public int Height;
  
		public ScreenSize(int w, int h)
       	{
           	Width = w;
   		    Height = h;
       	}
   	}
	
	public struct StageEventData
	{
		public float Time;
		public Action Func;
		
		public StageEventData(float time, Action func){
			Time = time;  Func = func;
		}
	}
	
	public struct SkillEffectStatus
	{
		public bool Status;
		public float EndTime;
		
		public SkillEffectStatus(bool status, float endTime){
			Status = status;  EndTime = endTime;	
		}
	}
	
}

