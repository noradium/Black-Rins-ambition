using System;
using Sce.PlayStation.Core.Audio;


namespace ShootingApp
{
	public static class Sounds
	{
		// BGM 変数宣言
		public static BgmPlayer bgmPlayer;
		public static Bgm stage1;
		public static Bgm stage1boss;
		public static Bgm title;
		public static Bgm gameover;
		
		
		
		// SE 変数宣言
		public static Sound sound;
		public static SoundPlayer shot;
		public static SoundPlayer siren;
		public static SoundPlayer hidan;
		public static SoundPlayer stageClear;
		public static SoundPlayer ok;
		public static SoundPlayer cancel;
		public static SoundPlayer tekihidan;
		public static SoundPlayer skill1;
		public static SoundPlayer skill2;
		public static SoundPlayer ticktuck;
			
		public static void InitSound ()
		{
			stage1 = new Bgm("/Application/resourses/stage1.mp3");
			stage1boss = new Bgm("/Application/resourses/stage1boss.mp3");
			title = new Bgm("/Application/resourses/title.mp3");
			gameover = new Bgm("/Application/resourses/gameover.mp3");
			
			
			bgmPlayer = stage1.CreatePlayer();
			
			sound = new Sound("/Application/resourses/shot.wav");
			shot = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/hidan.wav");
			hidan = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/siren.wav");
			siren = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/stageClear.wav");
			stageClear = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/system1.wav");
			ok = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/system2.wav");
			cancel = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/damage.wav");
			tekihidan = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/skillSE1.wav");
			skill1 = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/skillSE2.wav");
			skill2 = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/stageClear.wav");
			stageClear = sound.CreatePlayer();
			sound = new Sound("/Application/resourses/tick.wav");
			ticktuck = sound.CreatePlayer();
		}
		public static void PlayStage1(){
			bgmPlayer.Dispose();
			bgmPlayer = stage1.CreatePlayer();
			bgmPlayer.Loop = true;
			bgmPlayer.Play();
		}
		public static void PlayStage1boss(){
			bgmPlayer.Dispose();
			bgmPlayer = stage1boss.CreatePlayer();
			bgmPlayer.Loop = true;
			bgmPlayer.Play();
		}
		public static void PlayGameover(){
			bgmPlayer.Dispose();
			bgmPlayer = gameover.CreatePlayer();
			bgmPlayer.Loop = true;
			bgmPlayer.Play();
		}
		public static void PlayTitle(){
			bgmPlayer.Dispose();
			bgmPlayer = title.CreatePlayer();
			bgmPlayer.Loop = true;
			bgmPlayer.Play();
		}
		public static void StopBgm(){
			bgmPlayer.Stop();	
		}
		public static void PauseBgm(){
			bgmPlayer.Pause();	
		}
		public static void ResumeBgm(){
			bgmPlayer.Resume();	
		}
		
		
		
		public static void PlayShot(){
			shot.Play();	
		}
		public static void PlayHidan(){
			hidan.Play();	
		}
		public static void PlaySiren(){
			siren.Play();	
		}
		public static void PlayStageClear(){
			stageClear.Play();	
		}
		public static void PlayOk(){
			ok.Play();	
		}
		public static void PlayCancel(){
			cancel.Play();	
		}
		public static void PlayTekihidan(){
			tekihidan.Play();	
		}
		public static void PlaySkill1(){
			skill1.Play();	
		}
		public static void PlaySkill2(){
			skill2.Play();	
		}
		public static void PlayTicktuck(){
			ticktuck.Play();	
		}
		public static void StopTicktuck(){
			ticktuck.Stop();	
		}
	}
}

